// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Integer;
import java.util.Objects;


public final class K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs extends com.pulumi.resources.ResourceArgs {

    public static final K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs Empty = new K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs();

    @Import(name="observationPeriodInMinutes", required=true)
    private Output<Integer> observationPeriodInMinutes;

    public Output<Integer> observationPeriodInMinutes() {
        return this.observationPeriodInMinutes;
    }

    @Import(name="samplePeriodInMinutes", required=true)
    private Output<Integer> samplePeriodInMinutes;

    public Output<Integer> samplePeriodInMinutes() {
        return this.samplePeriodInMinutes;
    }

    private K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs() {}

    private K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs(K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs $) {
        this.observationPeriodInMinutes = $.observationPeriodInMinutes;
        this.samplePeriodInMinutes = $.samplePeriodInMinutes;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs $;

        public Builder() {
            $ = new K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs();
        }

        public Builder(K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs defaults) {
            $ = new K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs(Objects.requireNonNull(defaults));
        }

        public Builder observationPeriodInMinutes(Output<Integer> observationPeriodInMinutes) {
            $.observationPeriodInMinutes = observationPeriodInMinutes;
            return this;
        }

        public Builder observationPeriodInMinutes(Integer observationPeriodInMinutes) {
            return observationPeriodInMinutes(Output.of(observationPeriodInMinutes));
        }

        public Builder samplePeriodInMinutes(Output<Integer> samplePeriodInMinutes) {
            $.samplePeriodInMinutes = samplePeriodInMinutes;
            return this;
        }

        public Builder samplePeriodInMinutes(Integer samplePeriodInMinutes) {
            return samplePeriodInMinutes(Output.of(samplePeriodInMinutes));
        }

        public K8sWorkloadAnomaliesWorkloadWithoutReadyPodsConfigurationArgs build() {
            $.observationPeriodInMinutes = Objects.requireNonNull($.observationPeriodInMinutes, "expected parameter 'observationPeriodInMinutes' to be non-null");
            $.samplePeriodInMinutes = Objects.requireNonNull($.samplePeriodInMinutes, "expected parameter 'samplePeriodInMinutes' to be non-null");
            return $;
        }
    }

}