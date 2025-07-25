// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class K8sMonitoring extends pulumi.CustomResource {
    /**
     * Get an existing K8sMonitoring resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: K8sMonitoringState, opts?: pulumi.CustomResourceOptions): K8sMonitoring {
        return new K8sMonitoring(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/k8sMonitoring:K8sMonitoring';

    /**
     * Returns true if the given object is an instance of K8sMonitoring.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is K8sMonitoring {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === K8sMonitoring.__pulumiType;
    }

    /**
     * Monitor Kubernetes namespaces, services, workloads, and pods
     */
    public readonly cloudApplicationPipelineEnabled!: pulumi.Output<boolean>;
    /**
     * Define Kubernetes event filters to ingest events into your environment. For more details, see the
     * [documentation](https://dt-url.net/2201p0u).
     */
    public readonly eventPatterns!: pulumi.Output<outputs.K8sMonitoringEventPatterns | undefined>;
    /**
     * All events are monitored unless event filters are specified. All ingested events are subject to licensing by default.
     */
    public readonly eventProcessingActive!: pulumi.Output<boolean>;
    /**
     * Include only events specified by Events Field Selectors
     */
    public readonly filterEvents!: pulumi.Output<boolean | undefined>;
    /**
     * For a list of included events, see the [documentation](https://dt-url.net/l61d02no).
     */
    public readonly includeAllFdiEvents!: pulumi.Output<boolean | undefined>;
    /**
     * Workload and node resource metrics are based on a subset of cAdvisor metrics. Depending on your Kubernetes cluster size,
     * this may increase the CPU/memory resource consumption of your ActiveGate.
     */
    public readonly openMetricsBuiltinEnabled!: pulumi.Output<boolean>;
    /**
     * For annotation guidance, see the [documentation](https://dt-url.net/g42i0ppw).
     */
    public readonly openMetricsPipelineEnabled!: pulumi.Output<boolean>;
    /**
     * To enable dashboards and alerts, add the Kubernetes persistent volume claims extension to your environment.
     *
     * @deprecated This attribute is deprecated, see [this community guide](https://dt-url.net/v2200u4m) for details.
     */
    public readonly pvcMonitoringEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;

    /**
     * Create a K8sMonitoring resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: K8sMonitoringArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: K8sMonitoringArgs | K8sMonitoringState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as K8sMonitoringState | undefined;
            resourceInputs["cloudApplicationPipelineEnabled"] = state ? state.cloudApplicationPipelineEnabled : undefined;
            resourceInputs["eventPatterns"] = state ? state.eventPatterns : undefined;
            resourceInputs["eventProcessingActive"] = state ? state.eventProcessingActive : undefined;
            resourceInputs["filterEvents"] = state ? state.filterEvents : undefined;
            resourceInputs["includeAllFdiEvents"] = state ? state.includeAllFdiEvents : undefined;
            resourceInputs["openMetricsBuiltinEnabled"] = state ? state.openMetricsBuiltinEnabled : undefined;
            resourceInputs["openMetricsPipelineEnabled"] = state ? state.openMetricsPipelineEnabled : undefined;
            resourceInputs["pvcMonitoringEnabled"] = state ? state.pvcMonitoringEnabled : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
        } else {
            const args = argsOrState as K8sMonitoringArgs | undefined;
            if ((!args || args.cloudApplicationPipelineEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cloudApplicationPipelineEnabled'");
            }
            if ((!args || args.eventProcessingActive === undefined) && !opts.urn) {
                throw new Error("Missing required property 'eventProcessingActive'");
            }
            if ((!args || args.openMetricsBuiltinEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'openMetricsBuiltinEnabled'");
            }
            if ((!args || args.openMetricsPipelineEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'openMetricsPipelineEnabled'");
            }
            resourceInputs["cloudApplicationPipelineEnabled"] = args ? args.cloudApplicationPipelineEnabled : undefined;
            resourceInputs["eventPatterns"] = args ? args.eventPatterns : undefined;
            resourceInputs["eventProcessingActive"] = args ? args.eventProcessingActive : undefined;
            resourceInputs["filterEvents"] = args ? args.filterEvents : undefined;
            resourceInputs["includeAllFdiEvents"] = args ? args.includeAllFdiEvents : undefined;
            resourceInputs["openMetricsBuiltinEnabled"] = args ? args.openMetricsBuiltinEnabled : undefined;
            resourceInputs["openMetricsPipelineEnabled"] = args ? args.openMetricsPipelineEnabled : undefined;
            resourceInputs["pvcMonitoringEnabled"] = args ? args.pvcMonitoringEnabled : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(K8sMonitoring.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering K8sMonitoring resources.
 */
export interface K8sMonitoringState {
    /**
     * Monitor Kubernetes namespaces, services, workloads, and pods
     */
    cloudApplicationPipelineEnabled?: pulumi.Input<boolean>;
    /**
     * Define Kubernetes event filters to ingest events into your environment. For more details, see the
     * [documentation](https://dt-url.net/2201p0u).
     */
    eventPatterns?: pulumi.Input<inputs.K8sMonitoringEventPatterns>;
    /**
     * All events are monitored unless event filters are specified. All ingested events are subject to licensing by default.
     */
    eventProcessingActive?: pulumi.Input<boolean>;
    /**
     * Include only events specified by Events Field Selectors
     */
    filterEvents?: pulumi.Input<boolean>;
    /**
     * For a list of included events, see the [documentation](https://dt-url.net/l61d02no).
     */
    includeAllFdiEvents?: pulumi.Input<boolean>;
    /**
     * Workload and node resource metrics are based on a subset of cAdvisor metrics. Depending on your Kubernetes cluster size,
     * this may increase the CPU/memory resource consumption of your ActiveGate.
     */
    openMetricsBuiltinEnabled?: pulumi.Input<boolean>;
    /**
     * For annotation guidance, see the [documentation](https://dt-url.net/g42i0ppw).
     */
    openMetricsPipelineEnabled?: pulumi.Input<boolean>;
    /**
     * To enable dashboards and alerts, add the Kubernetes persistent volume claims extension to your environment.
     *
     * @deprecated This attribute is deprecated, see [this community guide](https://dt-url.net/v2200u4m) for details.
     */
    pvcMonitoringEnabled?: pulumi.Input<boolean>;
    /**
     * The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a K8sMonitoring resource.
 */
export interface K8sMonitoringArgs {
    /**
     * Monitor Kubernetes namespaces, services, workloads, and pods
     */
    cloudApplicationPipelineEnabled: pulumi.Input<boolean>;
    /**
     * Define Kubernetes event filters to ingest events into your environment. For more details, see the
     * [documentation](https://dt-url.net/2201p0u).
     */
    eventPatterns?: pulumi.Input<inputs.K8sMonitoringEventPatterns>;
    /**
     * All events are monitored unless event filters are specified. All ingested events are subject to licensing by default.
     */
    eventProcessingActive: pulumi.Input<boolean>;
    /**
     * Include only events specified by Events Field Selectors
     */
    filterEvents?: pulumi.Input<boolean>;
    /**
     * For a list of included events, see the [documentation](https://dt-url.net/l61d02no).
     */
    includeAllFdiEvents?: pulumi.Input<boolean>;
    /**
     * Workload and node resource metrics are based on a subset of cAdvisor metrics. Depending on your Kubernetes cluster size,
     * this may increase the CPU/memory resource consumption of your ActiveGate.
     */
    openMetricsBuiltinEnabled: pulumi.Input<boolean>;
    /**
     * For annotation guidance, see the [documentation](https://dt-url.net/g42i0ppw).
     */
    openMetricsPipelineEnabled: pulumi.Input<boolean>;
    /**
     * To enable dashboards and alerts, add the Kubernetes persistent volume claims extension to your environment.
     *
     * @deprecated This attribute is deprecated, see [this community guide](https://dt-url.net/v2200u4m) for details.
     */
    pvcMonitoringEnabled?: pulumi.Input<boolean>;
    /**
     * The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}
