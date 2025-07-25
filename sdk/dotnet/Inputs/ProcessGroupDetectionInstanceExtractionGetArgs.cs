// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class ProcessGroupDetectionInstanceExtractionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optionally delimit this property between *From* and *To*.
        /// </summary>
        [Input("delimiter")]
        public Input<Inputs.ProcessGroupDetectionInstanceExtractionDelimiterGetArgs>? Delimiter { get; set; }

        /// <summary>
        /// Possible values: `DOTNET_COMMAND`, `DOTNET_COMMAND_PATH`, `ASP_NET_CORE_APPLICATION_PATH`, `AWS_ECR_ACCOUNT_ID`, `AWS_ECR_REGION`, `AWS_ECS_CLUSTER`, `AWS_ECS_CONTAINERNAME`, `AWS_ECS_FAMILY`, `AWS_ECS_REVISION`, `AWS_LAMBDA_FUNCTION_NAME`, `AWS_REGION`, `APACHE_SPARK_MASTER_IP_ADDRESS`, `APACHE_CONFIG_PATH`, `CATALINA_BASE`, `CATALINA_HOME`, `CLOUD_FOUNDRY_APP_NAME`, `CLOUD_FOUNDRY_APPLICATION_ID`, `CLOUD_FOUNDRY_INSTANCE_INDEX`, `CLOUD_FOUNDRY_SPACE_NAME`, `CLOUD_FOUNDRY_SPACE_ID`, `COLDFUSION_JVM_CONFIG_FILE`, `SERVICE_NAME`, `COMMAND_LINE_ARGS`, `CONTAINER_ID`, `CONTAINER_IMAGE_VERSION`, `CONTAINER_NAME`, `DECLARATIVE_ID`, `CONTAINER_IMAGE_NAME`, `RUXIT_CLUSTER_ID`, `RUXIT_NODE_ID`, `EXE_NAME`, `EXE_PATH`, `ELASTIC_SEARCH_CLUSTER_NAME`, `ELASTIC_SEARCH_NODE_NAME`, `EQUINOX_CONFIG_PATH`, `GLASSFISH_DOMAIN_NAME`, `GLASSFISH_INSTANCE_NAME`, `PG_ID_CALC_INPUT_KEY_LINKAGE`, `GAE_INSTANCE`, `GAE_SERVICE`, `GOOGLE_CLOUD_PROJECT`, `HYBRIS_BIN_DIR`, `HYBRIS_CONFIG_DIR`, `HYBRIS_DATA_DIR`, `IBM_CICS_REGION`, `IBM_CICS_IMS_APPLID`, `IBM_CICS_IMS_JOBNAME`, `IBM_CTG_NAME`, `IBM_IMS_CONNECT`, `IBM_IMS_CONTROL`, `IBM_IMS_MPR`, `IBM_IMS_SOAP_GW_NAME`, `IIB_BROKER_NAME`, `IIB_EXECUTION_GROUP_NAME`, `IIS_APP_POOL`, `IIS_ROLE_NAME`, `JBOSS_HOME`, `JBOSS_MODE`, `JBOSS_SERVER_NAME`, `JAVA_JAR_FILE`, `JAVA_JAR_PATH`, `JAVA_MAIN_CLASS`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`, `MSSQL_INSTANCE_NAME`, `NODEJS_APP_NAME`, `NODEJS_APP_BASE_DIR`, `NODEJS_SCRIPT_NAME`, `ORACLE_SID`, `PHP_CLI_SCRIPT_PATH`, `PHP_CLI_WORKING_DIR`, `SOFTWAREAG_INSTALL_ROOT`, `SOFTWAREAG_PRODUCTPROPNAME`, `SPRINGBOOT_APP_NAME`, `SPRINGBOOT_PROFILE_NAME`, `SPRINGBOOT_STARTUP_CLASS`, `TIBCO_BUSINESSWORKS_CE_APP_NAME`, `TIBCO_BUSINESSWORKS_CE_VERSION`, `TIBCO_BUSINESSWORKS_APP_NODE_NAME`, `TIBCO_BUSINESSWORKS_APP_SPACE_NAME`, `TIBCO_BUSINESSWORKS_DOMAIN_NAME`, `TIPCO_BUSINESSWORKS_PROPERTY_FILE`, `TIPCO_BUSINESSWORKS_PROPERTY_FILE_PATH`, `TIBCO_BUSINESSWORKS_HOME`, `VARNISH_INSTANCE_NAME`, `WEBLOGIC_NAME`, `WEBLOGIC_CLUSTER_NAME`, `WEBLOGIC_DOMAIN_NAME`, `WEBLOGIC_HOME`, `WEBSPHERE_LIBERTY_SERVER_NAME`, `WEBSPHERE_CELL_NAME`, `WEBSPHERE_CLUSTER_NAME`, `WEBSPHERE_NODE_NAME`, `WEBSPHERE_SERVER_NAME`
        /// </summary>
        [Input("property")]
        public Input<string>? Property { get; set; }

        public ProcessGroupDetectionInstanceExtractionGetArgs()
        {
        }
        public static new ProcessGroupDetectionInstanceExtractionGetArgs Empty => new ProcessGroupDetectionInstanceExtractionGetArgs();
    }
}
