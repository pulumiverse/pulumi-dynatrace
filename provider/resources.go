// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package dynatrace

import (
	"fmt"
	"path/filepath"
	"strings"
	"unicode"

	dynatrace "github.com/dynatrace-oss/terraform-provider-dynatrace/provider"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	tfbridgetokens "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge/tokens"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"github.com/pulumi/pulumi/sdk/v3/go/common/tokens"
	"github.com/pulumiverse/pulumi-dynatrace/provider/pkg/version"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "dynatrace"
	// modules:
	mainMod = "index"
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

var namespaceMap = map[string]string{
	"dynatrace": "Dynatrace",
}

// dynatraceMember manufactures a type token for the Harness package and the given module and type.
func dynatraceMember(moduleTitle string, fn string, mem string) tokens.ModuleMember {
	moduleName := strings.ToLower(moduleTitle)
	namespaceMap[moduleName] = moduleTitle
	if fn != "" {
		moduleName += "/" + fn
	}
	return tokens.ModuleMember(mainPkg + ":" + moduleName + ":" + mem)
}

// dynatraceType manufactures a type token for the Launch Darkly package and the given module and type.
func dynatraceType(mod string, fn string, typ string) tokens.Type {
	return tokens.Type(dynatraceMember(mod, fn, typ))
}

func dynatraceTypeDefaultFile(mod string, typ string) tokens.Type {
	fn := string(unicode.ToLower(rune(typ[0]))) + typ[1:]
	return dynatraceType(mod, fn, typ)
}

// dynatraceDataSource manufactures a standard resource token given a module and resource name.
// It automatically uses the Launch Darkly package and names the file by simply lower casing the data
// source's first character.
func dynatraceDataSource(mod string, res string) tokens.ModuleMember {
	fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	return dynatraceMember(mod, fn, res)
}

// dynatraceResource manufactures a standard resource token given a module and resource name.
// It automatically uses the Launch Darkly package and names the file by simply lower casing the resource's
// first character.
func dynatraceResource(mod string, res string) tokens.Type {
	return dynatraceTypeDefaultFile(mod, res)
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(dynatrace.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:                 p,
		Name:              "dynatrace",
		DisplayName:       "Dynatrace",
		Publisher:         "Pulumiverse",
		LogoURL:           "https://raw.githubusercontent.com/pulumiverse/pulumi-dynatrace/master/assets/logo.png",
		PluginDownloadURL: "github://api.github.com/pulumiverse",
		Description:       "A Pulumi package for creating and managing Dynatrace cloud resources.",
		Keywords:          []string{"pulumi", "dynatrace", "category/infrastructure", "pulumiverse"},
		License:           "Apache-2.0",
		Homepage:          "https://www.pulumi.com",
		Repository:        "https://github.com/pulumiverse/pulumi-dynatrace",
		GitHubOrg:         "dynatrace-oss",
		Config: map[string]*tfbridge.SchemaInfo{
			"dt_env_url": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"DYNATRACE_ENV_URL", "DT_ENV_URL"},
				},
			},
			"dt_api_token": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"DYNATRACE_API_TOKEN", "DT_API_TOKEN"},
				},
			},
			"dt_cluster_api_token": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"DYNATRACE_CLUSTER_API_TOKEN", "DT_CLUSTER_API_TOKEN"},
				},
			},
			"dt_cluster_url": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"DYNATRACE_CLUSTER_URL", "DT_CLUSTER_URL"},
				},
			},
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			"dynatrace_alerting":           {Tok: dynatraceResource(mainMod, "Alerting")},
			"dynatrace_activegate_token":   {Tok: dynatraceResource(mainMod, "ActivegateToken")},
			"dynatrace_activegate_updates": {Tok: dynatraceResource(mainMod, "ActivegateUpdates")},
			"dynatrace_alerting_profile":   {Tok: dynatraceResource(mainMod, "AlertingProfile")},
			"dynatrace_aix_extension":      {Tok: dynatraceResource(mainMod, "AixExtension")},
			"dynatrace_app_monitoring": {
				Tok: dynatraceResource(mainMod, "AppMonitoring"),
				Fields: map[string]*tfbridge.SchemaInfo{
					"app_monitoring": {
						CSharpName: "AppMonitoringOverrides",
					},
				},
			},
			"dynatrace_application_anomalies":         {Tok: dynatraceResource(mainMod, "ApplicationAnomalies")},
			"dynatrace_application_data_privacy":      {Tok: dynatraceResource(mainMod, "ApplicationDataPrivacy")},
			"dynatrace_application_detection_rule":    {Tok: dynatraceResource(mainMod, "ApplicationDetectionRule")},
			"dynatrace_application_error_rules":       {Tok: dynatraceResource(mainMod, "ApplicationErrorRules")},
			"dynatrace_api_detection":                 {Tok: dynatraceResource(mainMod, "ApiDetection")},
			"dynatrace_api_token":                     {Tok: dynatraceResource(mainMod, "ApiToken")},
			"dynatrace_application_detection_rule_v2": {Tok: dynatraceResource(mainMod, "ApplicationDetectionRuleV2")},
			"dynatrace_ansible_tower_notification":    {Tok: dynatraceResource(mainMod, "AnsibleTowerNotification")},
			"dynatrace_autotag":                       {Tok: dynatraceResource(mainMod, "Autotag")},
			"dynatrace_aws_credentials":               {Tok: dynatraceResource(mainMod, "AwsCredentials")},
			"dynatrace_audit_log":                     {Tok: dynatraceResource(mainMod, "AuditLog")},
			"dynatrace_autotag_v2":                    {Tok: dynatraceResource(mainMod, "AutotagV2")},
			"dynatrace_aws_anomalies":                 {Tok: dynatraceResource(mainMod, "AwsAnomalies")},
			"dynatrace_azure_credentials":             {Tok: dynatraceResource(mainMod, "AzureCredentials")},
			"dynatrace_browser_monitor":               {Tok: dynatraceResource(mainMod, "BrowserMonitor")},
			"dynatrace_browser_monitor_outage":        {Tok: dynatraceResource(mainMod, "BrowserMonitorOutage")},
			"dynatrace_browser_monitor_performance":   {Tok: dynatraceResource(mainMod, "BrowserMonitorPerformance")},
			"dynatrace_business_events_buckets":       {Tok: dynatraceResource(mainMod, "BusinessEventsBuckets")},
			"dynatrace_business_events_metrics":       {Tok: dynatraceResource(mainMod, "BusinessEventsMetrics")},
			"dynatrace_business_events_oneagent":      {Tok: dynatraceResource(mainMod, "BusinessEventsOneagent")},
			"dynatrace_business_events_processing":    {Tok: dynatraceResource(mainMod, "BusinessEventsProcessing")},
			"dynatrace_calculated_service_metric":     {Tok: dynatraceResource(mainMod, "CalculatedServiceMetric")},
			"dynatrace_cloudfoundry_credentials":      {Tok: dynatraceResource(mainMod, "CloudfoundryCredentials")},
			"dynatrace_cloud_foundry":                 {Tok: dynatraceResource(mainMod, "CloudFoundry")},
			"dynatrace_cloudapp_workloaddetection":    {Tok: dynatraceResource(mainMod, "CloudappWorkloaddetection")},
			"dynatrace_cloud_development_environments": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "CloudDevelopmentEnvironments"),
				Fields: map[string]*tfbridge.SchemaInfo{
					"cloud_development_environments": {
						CSharpName: "Environments",
					},
				},
			},
			"dynatrace_connectivity_alerts": {
				Tok:    dynatraceResource(mainMod, "ConnectivityAlerts"),
				Fields: map[string]*tfbridge.SchemaInfo{"connectivity_alerts": {CSharpName: "EnableConnectivityAlerts"}},
			},
			"dynatrace_container_builtin_rule": {Tok: dynatraceResource(mainMod, "ContainerBuiltinRule")},
			"dynatrace_container_registry": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "ContainerRegistry"),
				Fields: map[string]*tfbridge.SchemaInfo{
					"container_registry": {
						CSharpName: "RegistryUrl",
					},
				},
			},
			"dynatrace_container_rule":                 {Tok: dynatraceResource(mainMod, "ContainerRule")},
			"dynatrace_container_technology":           {Tok: dynatraceResource(mainMod, "ContainerTechnology")},
			"dynatrace_credentials":                    {Tok: dynatraceResource(mainMod, "Credentials")},
			"dynatrace_custom_app_anomalies":           {Tok: dynatraceResource(mainMod, "CustomAppAnomalies")},
			"dynatrace_custom_app_crash_rate":          {Tok: dynatraceResource(mainMod, "CustomAppCrashRate")},
			"dynatrace_custom_app_enablement":          {Tok: dynatraceResource(mainMod, "CustomAppEnablement")},
			"dynatrace_custom_tags":                    {Tok: dynatraceResource(mainMod, "CustomTags")},
			"dynatrace_custom_units":                   {Tok: dynatraceResource(mainMod, "CustomUnits")},
			"dynatrace_dashboards_allowlist":           {Tok: dynatraceResource(mainMod, "DashboardsAllowlist")},
			"dynatrace_dashboards_general":             {Tok: dynatraceResource(mainMod, "DashboardsGeneral")},
			"dynatrace_dashboards_presets":             {Tok: dynatraceResource(mainMod, "DashboardsPresets")},
			"dynatrace_data_privacy":                   {Tok: dynatraceResource(mainMod, "DataPrivacy")},
			"dynatrace_database_anomalies_v2":          {Tok: dynatraceResource(mainMod, "DatabaseAnomaliesV2")},
			"dynatrace_ddu_pool":                       {Tok: dynatraceResource(mainMod, "DduPool")},
			"dynatrace_custom_anomalies":               {Tok: dynatraceResource(mainMod, "CustomAnomalies")},
			"dynatrace_custom_service":                 {Tok: dynatraceResource(mainMod, "CustomService")},
			"dynatrace_dashboard":                      {Tok: dynatraceResource(mainMod, "Dashboard")},
			"dynatrace_dashboard_sharing":              {Tok: dynatraceResource(mainMod, "DashboardSharing")},
			"dynatrace_database_anomalies":             {Tok: dynatraceResource(mainMod, "DatabaseAnomalies")},
			"dynatrace_disk_anomalies":                 {Tok: dynatraceResource(mainMod, "DiskAnomalies")},
			"dynatrace_declarative_grouping":           {Tok: dynatraceResource(mainMod, "DeclarativeGrouping")},
			"dynatrace_disk_analytics":                 {Tok: dynatraceResource(mainMod, "DiskAnalytics")},
			"dynatrace_disk_anomalies_v2":              {Tok: dynatraceResource(mainMod, "DiskAnomaliesV2")},
			"dynatrace_disk_anomaly_rules":             {Tok: dynatraceResource(mainMod, "DiskAnomalyRules")},
			"dynatrace_disk_options":                   {Tok: dynatraceResource(mainMod, "DiskOptions")},
			"dynatrace_disk_specific_anomalies_v2":     {Tok: dynatraceResource(mainMod, "DiskSpecificAnomaliesV2")},
			"dynatrace_eula_settings":                  {Tok: dynatraceResource(mainMod, "EulaSettings")},
			"dynatrace_extension_execution_controller": {Tok: dynatraceResource(mainMod, "ExtensionExecutionController")},
			"dynatrace_extension_execution_remote":     {Tok: dynatraceResource(mainMod, "ExtensionExecutionRemote")},
			"dynatrace_environment":                    {Tok: dynatraceResource(mainMod, "Environment")},
			"dynatrace_email_notification":             {Tok: dynatraceResource(mainMod, "EmailNotification")},
			"dynatrace_failure_detection_parameters":   {Tok: dynatraceResource(mainMod, "FailureDetectionParameters")},
			"dynatrace_failure_detection_rules":        {Tok: dynatraceResource(mainMod, "FailureDetectionRules")},
			"dynatrace_frequent_issues":                {Tok: dynatraceResource(mainMod, "FrequentIssues")},
			"dynatrace_generic_relationships":          {Tok: dynatraceResource(mainMod, "GenericRelationships")},
			"dynatrace_generic_types":                  {Tok: dynatraceResource(mainMod, "GenericTypes")},
			"dynatrace_geolocation":                    {Tok: dynatraceResource(mainMod, "Geolocation")},
			"dynatrace_host_anomalies_v2":              {Tok: dynatraceResource(mainMod, "HostAnomaliesV2")},
			"dynatrace_host_anomalies":                 {Tok: dynatraceResource(mainMod, "HostAnomalies")},
			"dynatrace_host_monitoring":                {Tok: dynatraceResource(mainMod, "HostMonitoring")},
			"dynatrace_host_process_group_monitoring":  {Tok: dynatraceResource(mainMod, "HostProcessGroupMonitoring")},
			"dynatrace_http_monitor_cookies":           {Tok: dynatraceResource(mainMod, "HttpMonitorCookies")},
			"dynatrace_http_monitor_outage":            {Tok: dynatraceResource(mainMod, "HttpMonitorOutage")},
			"dynatrace_http_monitor_performance":       {Tok: dynatraceResource(mainMod, "HttpMonitorPerformance")},
			"dynatrace_host_naming":                    {Tok: dynatraceResource(mainMod, "HostNaming")},
			"dynatrace_http_monitor":                   {Tok: dynatraceResource(mainMod, "HttpMonitor")},
			"dynatrace_iam_group":                      {Tok: dynatraceResource(mainMod, "IamGroup")},
			"dynatrace_iam_permission":                 {Tok: dynatraceResource(mainMod, "IamPermission")},
			"dynatrace_iam_policy":                     {Tok: dynatraceResource(mainMod, "IamPolicy")},
			"dynatrace_iam_policy_bindings":            {Tok: dynatraceResource(mainMod, "IamPolicyBindings")},
			"dynatrace_iam_user":                       {Tok: dynatraceResource(mainMod, "IamUser")},
			"dynatrace_ibm_mq_filters":                 {Tok: dynatraceResource(mainMod, "IbmMqFilters")},
			"dynatrace_ims_bridges":                    {Tok: dynatraceResource(mainMod, "ImsBridges")},
			"dynatrace_issue_tracking":                 {Tok: dynatraceResource(mainMod, "IssueTracking")},
			"dynatrace_jira_notification":              {Tok: dynatraceResource(mainMod, "JiraNotification")},
			"dynatrace_json_dashboard":                 {Tok: dynatraceResource(mainMod, "JsonDashboard")},
			"dynatrace_k8s_credentials":                {Tok: dynatraceResource(mainMod, "K8sCredentials")},
			"dynatrace_k8s_cluster_anomalies":          {Tok: dynatraceResource(mainMod, "K8sClusterAnomalies")},
			"dynatrace_k8s_namespace_anomalies":        {Tok: dynatraceResource(mainMod, "K8sNamespaceAnomalies")},
			"dynatrace_k8s_node_anomalies":             {Tok: dynatraceResource(mainMod, "K8sNodeAnomalies")},
			"dynatrace_k8s_pvc_anomalies":              {Tok: dynatraceResource(mainMod, "K8sPvcAnomalies")},
			"dynatrace_k8s_workload_anomalies":         {Tok: dynatraceResource(mainMod, "K8sWorkloadAnomalies")},
			"dynatrace_kubernetes":                     {Tok: dynatraceResource(mainMod, "Kubernetes")},
			"dynatrace_key_requests":                   {Tok: dynatraceResource(mainMod, "KeyRequests")},
			"dynatrace_log_buckets":                    {Tok: dynatraceResource(mainMod, "LogBuckets")},
			"dynatrace_log_custom_attribute":           {Tok: dynatraceResource(mainMod, "LogCustomAttribute")},
			"dynatrace_log_custom_source":              {Tok: dynatraceResource(mainMod, "LogCustomSource")},
			"dynatrace_log_events":                     {Tok: dynatraceResource(mainMod, "LogEvents")},
			"dynatrace_log_grail":                      {Tok: dynatraceResource(mainMod, "LogGrail")},
			"dynatrace_log_metrics":                    {Tok: dynatraceResource(mainMod, "LogMetrics")},
			"dynatrace_log_oneagent":                   {Tok: dynatraceResource(mainMod, "LogOneagent")},
			"dynatrace_log_processing":                 {Tok: dynatraceResource(mainMod, "LogProcessing")},

			"dynatrace_maintenance":              {Tok: dynatraceResource(mainMod, "Maintenance")},
			"dynatrace_maintenance_window":       {Tok: dynatraceResource(mainMod, "MaintenanceWindow")},
			"dynatrace_management_zone":          {Tok: dynatraceResource(mainMod, "ManagementZone")},
			"dynatrace_mobile_application":       {Tok: dynatraceResource(mainMod, "MobileApplication")},
			"dynatrace_network_zones":            {Tok: dynatraceResource(mainMod, "NetworkZones")},
			"dynatrace_notification":             {Tok: dynatraceResource(mainMod, "Notification")},
			"dynatrace_ops_genie_notification":   {Tok: dynatraceResource(mainMod, "OpsGenieNotification")},
			"dynatrace_pager_duty_notification":  {Tok: dynatraceResource(mainMod, "PagerDutyNotification")},
			"dynatrace_processgroup_naming":      {Tok: dynatraceResource(mainMod, "ProcessgroupNaming")},
			"dynatrace_queue_manager":            {Tok: dynatraceResource(mainMod, "QueueManager")},
			"dynatrace_queue_sharing_groups":     {Tok: dynatraceResource(mainMod, "QueueSharingGroups")},
			"dynatrace_request_attribute":        {Tok: dynatraceResource(mainMod, "RequestAttribute")},
			"dynatrace_request_naming":           {Tok: dynatraceResource(mainMod, "RequestNaming")},
			"dynatrace_request_namings":          {Tok: dynatraceResource(mainMod, "RequestNamings")},
			"dynatrace_resource_attributes":      {Tok: dynatraceResource(mainMod, "ResourceAttributes")},
			"dynatrace_service_anomalies":        {Tok: dynatraceResource(mainMod, "ServiceAnomalies")},
			"dynatrace_service_naming":           {Tok: dynatraceResource(mainMod, "ServiceNaming")},
			"dynatrace_service_now_notification": {Tok: dynatraceResource(mainMod, "ServiceNowNotification")},
			"dynatrace_slack_notification":       {Tok: dynatraceResource(mainMod, "SlackNotification")},
			"dynatrace_slo":                      {Tok: dynatraceResource(mainMod, "Slo")},
			"dynatrace_span_attribute":           {Tok: dynatraceResource(mainMod, "SpanAttributed")},
			"dynatrace_span_capture_rule":        {Tok: dynatraceResource(mainMod, "SpanCaptureRule")},
			"dynatrace_span_context_propagation": {Tok: dynatraceResource(mainMod, "SpanContextPropagation")},
			"dynatrace_span_entry_point":         {Tok: dynatraceResource(mainMod, "SpanEntryPoint")},
			"dynatrace_trello_notification":      {Tok: dynatraceResource(mainMod, "TrelloNotification")},
			"dynatrace_user":                     {Tok: dynatraceResource(mainMod, "User")},
			"dynatrace_user_group":               {Tok: dynatraceResource(mainMod, "UserGroup")},
			"dynatrace_victor_ops_notification":  {Tok: dynatraceResource(mainMod, "VictorOpsNotification")},
			"dynatrace_web_application":          {Tok: dynatraceResource(mainMod, "WebApplication")},
			"dynatrace_webhook_notification":     {Tok: dynatraceResource(mainMod, "WebhookNotification")},
			"dynatrace_xmatters_notification":    {Tok: dynatraceResource(mainMod, "XmattersNotification")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"dynatrace_alerting_profile":    {Tok: dynatraceDataSource(mainMod, "getAlertingProfile")},
			"dynatrace_alerting_profiles":   {Tok: dynatraceDataSource(mainMod, "getAlertingProfiles")},
			"dynatrace_application":         {Tok: dynatraceDataSource(mainMod, "getApplication")},
			"dynatrace_aws_iam_external":    {Tok: dynatraceDataSource(mainMod, "getAwsIamExternal")},
			"dynatrace_credentials":         {Tok: dynatraceDataSource(mainMod, "getCredentials")},
			"dynatrace_host":                {Tok: dynatraceDataSource(mainMod, "getHost")},
			"dynatrace_management_zone":     {Tok: dynatraceDataSource(mainMod, "getManagementZone")},
			"dynatrace_process":             {Tok: dynatraceDataSource(mainMod, "getProcess")},
			"dynatrace_process_group":       {Tok: dynatraceDataSource(mainMod, "getProcessGroup")},
			"dynatrace_service":             {Tok: dynatraceDataSource(mainMod, "getService")},
			"dynatrace_synthetic_location":  {Tok: dynatraceDataSource(mainMod, "getSyntheticLocation")},
			"dynatrace_synthetic_locations": {Tok: dynatraceDataSource(mainMod, "getSyntheticLocations")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@pulumiverse/dynatrace",
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
			PackageName: "pulumiverse_dynatrace",
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pulumiverse/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
			RootNamespace: "Pulumiverse",
		},
	}

	prov.MustComputeTokens(tfbridgetokens.SingleModule("dynatrace_", mainMod, tfbridgetokens.MakeStandard(mainPkg)))

	prov.SetAutonaming(255, "-")

	prov.SetAutonaming(255, "-")

	return prov
}
