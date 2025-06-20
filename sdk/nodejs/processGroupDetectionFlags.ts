// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class ProcessGroupDetectionFlags extends pulumi.CustomResource {
    /**
     * Get an existing ProcessGroupDetectionFlags resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProcessGroupDetectionFlagsState, opts?: pulumi.CustomResourceOptions): ProcessGroupDetectionFlags {
        return new ProcessGroupDetectionFlags(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/processGroupDetectionFlags:ProcessGroupDetectionFlags';

    /**
     * Returns true if the given object is an instance of ProcessGroupDetectionFlags.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProcessGroupDetectionFlags {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProcessGroupDetectionFlags.__pulumiType;
    }

    /**
     * In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
     */
    public readonly addNodeJsScriptName!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
     */
    public readonly autoDetectCassandraClusters!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
     */
    public readonly autoDetectSpringBoot!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    public readonly autoDetectTibcoContainerEditionEngines!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    public readonly autoDetectTibcoEngines!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
     */
    public readonly autoDetectWebMethodsIntegrationServer!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
     */
    public readonly autoDetectWebSphereLibertyApplication!: pulumi.Output<boolean>;
    /**
     * Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
     */
    public readonly groupIbmmqbyInstanceName!: pulumi.Output<boolean>;
    /**
     * Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
     */
    public readonly identifyJbossServerBySystemProperty!: pulumi.Output<boolean>;
    /**
     * To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
     */
    public readonly ignoreUniqueIdentifiers!: pulumi.Output<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;
    /**
     * This flag enables the detection of security software such as anti-malware protection.
     */
    public readonly securitySoftwareDetectionEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
     */
    public readonly shortLivedProcessesMonitoring!: pulumi.Output<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
     */
    public readonly splitOracleDatabasePg!: pulumi.Output<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
     */
    public readonly splitOracleListenerPg!: pulumi.Output<boolean>;
    /**
     * By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
     */
    public readonly useCatalinaBase!: pulumi.Output<boolean>;
    /**
     * By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
     */
    public readonly useDockerContainerName!: pulumi.Output<boolean>;

    /**
     * Create a ProcessGroupDetectionFlags resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProcessGroupDetectionFlagsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProcessGroupDetectionFlagsArgs | ProcessGroupDetectionFlagsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProcessGroupDetectionFlagsState | undefined;
            resourceInputs["addNodeJsScriptName"] = state ? state.addNodeJsScriptName : undefined;
            resourceInputs["autoDetectCassandraClusters"] = state ? state.autoDetectCassandraClusters : undefined;
            resourceInputs["autoDetectSpringBoot"] = state ? state.autoDetectSpringBoot : undefined;
            resourceInputs["autoDetectTibcoContainerEditionEngines"] = state ? state.autoDetectTibcoContainerEditionEngines : undefined;
            resourceInputs["autoDetectTibcoEngines"] = state ? state.autoDetectTibcoEngines : undefined;
            resourceInputs["autoDetectWebMethodsIntegrationServer"] = state ? state.autoDetectWebMethodsIntegrationServer : undefined;
            resourceInputs["autoDetectWebSphereLibertyApplication"] = state ? state.autoDetectWebSphereLibertyApplication : undefined;
            resourceInputs["groupIbmmqbyInstanceName"] = state ? state.groupIbmmqbyInstanceName : undefined;
            resourceInputs["identifyJbossServerBySystemProperty"] = state ? state.identifyJbossServerBySystemProperty : undefined;
            resourceInputs["ignoreUniqueIdentifiers"] = state ? state.ignoreUniqueIdentifiers : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["securitySoftwareDetectionEnabled"] = state ? state.securitySoftwareDetectionEnabled : undefined;
            resourceInputs["shortLivedProcessesMonitoring"] = state ? state.shortLivedProcessesMonitoring : undefined;
            resourceInputs["splitOracleDatabasePg"] = state ? state.splitOracleDatabasePg : undefined;
            resourceInputs["splitOracleListenerPg"] = state ? state.splitOracleListenerPg : undefined;
            resourceInputs["useCatalinaBase"] = state ? state.useCatalinaBase : undefined;
            resourceInputs["useDockerContainerName"] = state ? state.useDockerContainerName : undefined;
        } else {
            const args = argsOrState as ProcessGroupDetectionFlagsArgs | undefined;
            if ((!args || args.addNodeJsScriptName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'addNodeJsScriptName'");
            }
            if ((!args || args.autoDetectCassandraClusters === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectCassandraClusters'");
            }
            if ((!args || args.autoDetectSpringBoot === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectSpringBoot'");
            }
            if ((!args || args.autoDetectTibcoContainerEditionEngines === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectTibcoContainerEditionEngines'");
            }
            if ((!args || args.autoDetectTibcoEngines === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectTibcoEngines'");
            }
            if ((!args || args.autoDetectWebMethodsIntegrationServer === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectWebMethodsIntegrationServer'");
            }
            if ((!args || args.autoDetectWebSphereLibertyApplication === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoDetectWebSphereLibertyApplication'");
            }
            if ((!args || args.groupIbmmqbyInstanceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupIbmmqbyInstanceName'");
            }
            if ((!args || args.identifyJbossServerBySystemProperty === undefined) && !opts.urn) {
                throw new Error("Missing required property 'identifyJbossServerBySystemProperty'");
            }
            if ((!args || args.ignoreUniqueIdentifiers === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ignoreUniqueIdentifiers'");
            }
            if ((!args || args.shortLivedProcessesMonitoring === undefined) && !opts.urn) {
                throw new Error("Missing required property 'shortLivedProcessesMonitoring'");
            }
            if ((!args || args.splitOracleDatabasePg === undefined) && !opts.urn) {
                throw new Error("Missing required property 'splitOracleDatabasePg'");
            }
            if ((!args || args.splitOracleListenerPg === undefined) && !opts.urn) {
                throw new Error("Missing required property 'splitOracleListenerPg'");
            }
            if ((!args || args.useCatalinaBase === undefined) && !opts.urn) {
                throw new Error("Missing required property 'useCatalinaBase'");
            }
            if ((!args || args.useDockerContainerName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'useDockerContainerName'");
            }
            resourceInputs["addNodeJsScriptName"] = args ? args.addNodeJsScriptName : undefined;
            resourceInputs["autoDetectCassandraClusters"] = args ? args.autoDetectCassandraClusters : undefined;
            resourceInputs["autoDetectSpringBoot"] = args ? args.autoDetectSpringBoot : undefined;
            resourceInputs["autoDetectTibcoContainerEditionEngines"] = args ? args.autoDetectTibcoContainerEditionEngines : undefined;
            resourceInputs["autoDetectTibcoEngines"] = args ? args.autoDetectTibcoEngines : undefined;
            resourceInputs["autoDetectWebMethodsIntegrationServer"] = args ? args.autoDetectWebMethodsIntegrationServer : undefined;
            resourceInputs["autoDetectWebSphereLibertyApplication"] = args ? args.autoDetectWebSphereLibertyApplication : undefined;
            resourceInputs["groupIbmmqbyInstanceName"] = args ? args.groupIbmmqbyInstanceName : undefined;
            resourceInputs["identifyJbossServerBySystemProperty"] = args ? args.identifyJbossServerBySystemProperty : undefined;
            resourceInputs["ignoreUniqueIdentifiers"] = args ? args.ignoreUniqueIdentifiers : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["securitySoftwareDetectionEnabled"] = args ? args.securitySoftwareDetectionEnabled : undefined;
            resourceInputs["shortLivedProcessesMonitoring"] = args ? args.shortLivedProcessesMonitoring : undefined;
            resourceInputs["splitOracleDatabasePg"] = args ? args.splitOracleDatabasePg : undefined;
            resourceInputs["splitOracleListenerPg"] = args ? args.splitOracleListenerPg : undefined;
            resourceInputs["useCatalinaBase"] = args ? args.useCatalinaBase : undefined;
            resourceInputs["useDockerContainerName"] = args ? args.useDockerContainerName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ProcessGroupDetectionFlags.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProcessGroupDetectionFlags resources.
 */
export interface ProcessGroupDetectionFlagsState {
    /**
     * In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
     */
    addNodeJsScriptName?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
     */
    autoDetectCassandraClusters?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
     */
    autoDetectSpringBoot?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    autoDetectTibcoContainerEditionEngines?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    autoDetectTibcoEngines?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
     */
    autoDetectWebMethodsIntegrationServer?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
     */
    autoDetectWebSphereLibertyApplication?: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
     */
    groupIbmmqbyInstanceName?: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
     */
    identifyJbossServerBySystemProperty?: pulumi.Input<boolean>;
    /**
     * To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
     */
    ignoreUniqueIdentifiers?: pulumi.Input<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * This flag enables the detection of security software such as anti-malware protection.
     */
    securitySoftwareDetectionEnabled?: pulumi.Input<boolean>;
    /**
     * Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
     */
    shortLivedProcessesMonitoring?: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
     */
    splitOracleDatabasePg?: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
     */
    splitOracleListenerPg?: pulumi.Input<boolean>;
    /**
     * By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
     */
    useCatalinaBase?: pulumi.Input<boolean>;
    /**
     * By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
     */
    useDockerContainerName?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a ProcessGroupDetectionFlags resource.
 */
export interface ProcessGroupDetectionFlagsArgs {
    /**
     * In older versions, Node.js applications were distinguished based on their directory name, omitting the script name. Changing this setting may change the general handling of Node.js process groups. Leave unchanged if in doubt.
     */
    addNodeJsScriptName: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate Cassandra process groups based on the configured Cassandra cluster name.
     */
    autoDetectCassandraClusters: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect Spring Boot process groups based on command line and applications' configuration files.
     */
    autoDetectSpringBoot: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    autoDetectTibcoContainerEditionEngines: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate TIBCO BusinessWorks process groups per engine property file.
     */
    autoDetectTibcoEngines: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect webMethods Integration Server including specific properties like install root and product name.
     */
    autoDetectWebMethodsIntegrationServer: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect separate WebSphere Liberty process groups based on java command line.
     */
    autoDetectWebSphereLibertyApplication: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each IBM MQ Queue manager instance. Each process group receives a unique name based on the queue manager instance name.
     */
    groupIbmmqbyInstanceName: pulumi.Input<boolean>;
    /**
     * Enabling this flag will detect the JBoss server name from the system property jboss.server.name=\n\n, only if -D[Server:\n\n] is not set.
     */
    identifyJbossServerBySystemProperty: pulumi.Input<boolean>;
    /**
     * To determine the unique identity of each detected process, and to generate a unique name for each detected process, Dynatrace evaluates the name of the directory that each process binary is contained within. For application containers like Tomcat and JBoss, Dynatrace evaluates important directories like CATALINA*HOME and JBOSS*HOME for this information. In some automated deployment scenarios such directory names are updated automatically with new version numbers, build numbers, dates, or GUIDs. Enable this setting to ensure that automated directory name changes don't result in Dynatrace registering pre-existing processes as new processes.
     */
    ignoreUniqueIdentifiers: pulumi.Input<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * This flag enables the detection of security software such as anti-malware protection.
     */
    securitySoftwareDetectionEnabled?: pulumi.Input<boolean>;
    /**
     * Enable to monitor CPU and memory usage of short lived processes, otherwise being lost by traditional monitoring. Disabling this flag blocks passing data to cluster only, it does not stop data collection and has no effect on performance.
     */
    shortLivedProcessesMonitoring: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle DB. Each process group receives a unique name based on the Oracle DB SID.
     */
    splitOracleDatabasePg: pulumi.Input<boolean>;
    /**
     * Enable to group and separately analyze the processes of each Oracle Listener. Each process group receives a unique name based on the Oracle Listener name.
     */
    splitOracleListenerPg: pulumi.Input<boolean>;
    /**
     * By default, Tomcat clusters are identified and named based on the CATALINA*HOME directory name. This setting results in the use of the CATALINA*BASE directory name to identify multiple Tomcat nodes within each Tomcat cluster. If this setting is not enabled, each CATALINA*HOME+CATALINA*BASE combination will be considered a separate Tomcat cluster. In other words, Tomcat clusters can't have multiple nodes on a single host.
     */
    useCatalinaBase: pulumi.Input<boolean>;
    /**
     * By default, Dynatrace uses image names as identifiers for individual process groups, with one process-group instance per host. Normally Docker container names can't serve as stable identifiers of process group instances because they are variable and auto-generated. You can however manually assign proper container names to their Docker instances. Such manually-assigned container names can serve as reliable process-group instance identifiers. This flag instructs Dynatrace to use Docker-provided names to distinguish between multiple instances of the same image. If this flag is not applied and you run multiple containers of the same image on the same host, the resulting processes will be consolidated into a single process view. Use this flag with caution!
     */
    useDockerContainerName: pulumi.Input<boolean>;
}
