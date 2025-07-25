// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/processGroupDetectionFlags:ProcessGroupDetectionFlags")]
    public partial class ProcessGroupDetectionFlags : global::Pulumi.CustomResource
    {
        /// <summary>
        /// In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
        /// </summary>
        [Output("addNodeJsScriptName")]
        public Output<bool> AddNodeJsScriptName { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
        /// </summary>
        [Output("autoDetectCassandraClusters")]
        public Output<bool> AutoDetectCassandraClusters { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
        /// </summary>
        [Output("autoDetectSpringBoot")]
        public Output<bool> AutoDetectSpringBoot { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Output("autoDetectTibcoContainerEditionEngines")]
        public Output<bool> AutoDetectTibcoContainerEditionEngines { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Output("autoDetectTibcoEngines")]
        public Output<bool> AutoDetectTibcoEngines { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
        /// </summary>
        [Output("autoDetectWebMethodsIntegrationServer")]
        public Output<bool> AutoDetectWebMethodsIntegrationServer { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
        /// </summary>
        [Output("autoDetectWebSphereLibertyApplication")]
        public Output<bool> AutoDetectWebSphereLibertyApplication { get; private set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
        /// </summary>
        [Output("groupIbmmqbyInstanceName")]
        public Output<bool> GroupIbmmqbyInstanceName { get; private set; } = null!;

        /// <summary>
        /// Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
        /// </summary>
        [Output("identifyJbossServerBySystemProperty")]
        public Output<bool> IdentifyJbossServerBySystemProperty { get; private set; } = null!;

        /// <summary>
        /// To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
        /// </summary>
        [Output("ignoreUniqueIdentifiers")]
        public Output<bool> IgnoreUniqueIdentifiers { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// This flag enables the detection of security software such as anti-malware protection.
        /// </summary>
        [Output("securitySoftwareDetectionEnabled")]
        public Output<bool?> SecuritySoftwareDetectionEnabled { get; private set; } = null!;

        /// <summary>
        /// Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
        /// </summary>
        [Output("shortLivedProcessesMonitoring")]
        public Output<bool> ShortLivedProcessesMonitoring { get; private set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
        /// </summary>
        [Output("splitOracleDatabasePg")]
        public Output<bool> SplitOracleDatabasePg { get; private set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
        /// </summary>
        [Output("splitOracleListenerPg")]
        public Output<bool> SplitOracleListenerPg { get; private set; } = null!;

        /// <summary>
        /// By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
        /// </summary>
        [Output("useCatalinaBase")]
        public Output<bool> UseCatalinaBase { get; private set; } = null!;

        /// <summary>
        /// By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
        /// </summary>
        [Output("useDockerContainerName")]
        public Output<bool> UseDockerContainerName { get; private set; } = null!;


        /// <summary>
        /// Create a ProcessGroupDetectionFlags resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProcessGroupDetectionFlags(string name, ProcessGroupDetectionFlagsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/processGroupDetectionFlags:ProcessGroupDetectionFlags", name, args ?? new ProcessGroupDetectionFlagsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProcessGroupDetectionFlags(string name, Input<string> id, ProcessGroupDetectionFlagsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/processGroupDetectionFlags:ProcessGroupDetectionFlags", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ProcessGroupDetectionFlags resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProcessGroupDetectionFlags Get(string name, Input<string> id, ProcessGroupDetectionFlagsState? state = null, CustomResourceOptions? options = null)
        {
            return new ProcessGroupDetectionFlags(name, id, state, options);
        }
    }

    public sealed class ProcessGroupDetectionFlagsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
        /// </summary>
        [Input("addNodeJsScriptName", required: true)]
        public Input<bool> AddNodeJsScriptName { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
        /// </summary>
        [Input("autoDetectCassandraClusters", required: true)]
        public Input<bool> AutoDetectCassandraClusters { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
        /// </summary>
        [Input("autoDetectSpringBoot", required: true)]
        public Input<bool> AutoDetectSpringBoot { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Input("autoDetectTibcoContainerEditionEngines", required: true)]
        public Input<bool> AutoDetectTibcoContainerEditionEngines { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Input("autoDetectTibcoEngines", required: true)]
        public Input<bool> AutoDetectTibcoEngines { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
        /// </summary>
        [Input("autoDetectWebMethodsIntegrationServer", required: true)]
        public Input<bool> AutoDetectWebMethodsIntegrationServer { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
        /// </summary>
        [Input("autoDetectWebSphereLibertyApplication", required: true)]
        public Input<bool> AutoDetectWebSphereLibertyApplication { get; set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
        /// </summary>
        [Input("groupIbmmqbyInstanceName", required: true)]
        public Input<bool> GroupIbmmqbyInstanceName { get; set; } = null!;

        /// <summary>
        /// Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
        /// </summary>
        [Input("identifyJbossServerBySystemProperty", required: true)]
        public Input<bool> IdentifyJbossServerBySystemProperty { get; set; } = null!;

        /// <summary>
        /// To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
        /// </summary>
        [Input("ignoreUniqueIdentifiers", required: true)]
        public Input<bool> IgnoreUniqueIdentifiers { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// This flag enables the detection of security software such as anti-malware protection.
        /// </summary>
        [Input("securitySoftwareDetectionEnabled")]
        public Input<bool>? SecuritySoftwareDetectionEnabled { get; set; }

        /// <summary>
        /// Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
        /// </summary>
        [Input("shortLivedProcessesMonitoring", required: true)]
        public Input<bool> ShortLivedProcessesMonitoring { get; set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
        /// </summary>
        [Input("splitOracleDatabasePg", required: true)]
        public Input<bool> SplitOracleDatabasePg { get; set; } = null!;

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
        /// </summary>
        [Input("splitOracleListenerPg", required: true)]
        public Input<bool> SplitOracleListenerPg { get; set; } = null!;

        /// <summary>
        /// By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
        /// </summary>
        [Input("useCatalinaBase", required: true)]
        public Input<bool> UseCatalinaBase { get; set; } = null!;

        /// <summary>
        /// By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
        /// </summary>
        [Input("useDockerContainerName", required: true)]
        public Input<bool> UseDockerContainerName { get; set; } = null!;

        public ProcessGroupDetectionFlagsArgs()
        {
        }
        public static new ProcessGroupDetectionFlagsArgs Empty => new ProcessGroupDetectionFlagsArgs();
    }

    public sealed class ProcessGroupDetectionFlagsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
        /// </summary>
        [Input("addNodeJsScriptName")]
        public Input<bool>? AddNodeJsScriptName { get; set; }

        /// <summary>
        /// Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
        /// </summary>
        [Input("autoDetectCassandraClusters")]
        public Input<bool>? AutoDetectCassandraClusters { get; set; }

        /// <summary>
        /// Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
        /// </summary>
        [Input("autoDetectSpringBoot")]
        public Input<bool>? AutoDetectSpringBoot { get; set; }

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Input("autoDetectTibcoContainerEditionEngines")]
        public Input<bool>? AutoDetectTibcoContainerEditionEngines { get; set; }

        /// <summary>
        /// Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
        /// </summary>
        [Input("autoDetectTibcoEngines")]
        public Input<bool>? AutoDetectTibcoEngines { get; set; }

        /// <summary>
        /// Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
        /// </summary>
        [Input("autoDetectWebMethodsIntegrationServer")]
        public Input<bool>? AutoDetectWebMethodsIntegrationServer { get; set; }

        /// <summary>
        /// Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
        /// </summary>
        [Input("autoDetectWebSphereLibertyApplication")]
        public Input<bool>? AutoDetectWebSphereLibertyApplication { get; set; }

        /// <summary>
        /// Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
        /// </summary>
        [Input("groupIbmmqbyInstanceName")]
        public Input<bool>? GroupIbmmqbyInstanceName { get; set; }

        /// <summary>
        /// Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
        /// </summary>
        [Input("identifyJbossServerBySystemProperty")]
        public Input<bool>? IdentifyJbossServerBySystemProperty { get; set; }

        /// <summary>
        /// To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
        /// </summary>
        [Input("ignoreUniqueIdentifiers")]
        public Input<bool>? IgnoreUniqueIdentifiers { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// This flag enables the detection of security software such as anti-malware protection.
        /// </summary>
        [Input("securitySoftwareDetectionEnabled")]
        public Input<bool>? SecuritySoftwareDetectionEnabled { get; set; }

        /// <summary>
        /// Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
        /// </summary>
        [Input("shortLivedProcessesMonitoring")]
        public Input<bool>? ShortLivedProcessesMonitoring { get; set; }

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
        /// </summary>
        [Input("splitOracleDatabasePg")]
        public Input<bool>? SplitOracleDatabasePg { get; set; }

        /// <summary>
        /// Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
        /// </summary>
        [Input("splitOracleListenerPg")]
        public Input<bool>? SplitOracleListenerPg { get; set; }

        /// <summary>
        /// By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
        /// </summary>
        [Input("useCatalinaBase")]
        public Input<bool>? UseCatalinaBase { get; set; }

        /// <summary>
        /// By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
        /// </summary>
        [Input("useDockerContainerName")]
        public Input<bool>? UseDockerContainerName { get; set; }

        public ProcessGroupDetectionFlagsState()
        {
        }
        public static new ProcessGroupDetectionFlagsState Empty => new ProcessGroupDetectionFlagsState();
    }
}
