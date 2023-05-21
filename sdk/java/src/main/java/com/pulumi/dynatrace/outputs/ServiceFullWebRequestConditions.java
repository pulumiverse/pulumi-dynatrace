// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.dynatrace.outputs.ServiceFullWebRequestConditionsCondition;
import java.util.List;
import java.util.Objects;

@CustomType
public final class ServiceFullWebRequestConditions {
    private List<ServiceFullWebRequestConditionsCondition> conditions;

    private ServiceFullWebRequestConditions() {}
    public List<ServiceFullWebRequestConditionsCondition> conditions() {
        return this.conditions;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(ServiceFullWebRequestConditions defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private List<ServiceFullWebRequestConditionsCondition> conditions;
        public Builder() {}
        public Builder(ServiceFullWebRequestConditions defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.conditions = defaults.conditions;
        }

        @CustomType.Setter
        public Builder conditions(List<ServiceFullWebRequestConditionsCondition> conditions) {
            this.conditions = Objects.requireNonNull(conditions);
            return this;
        }
        public Builder conditions(ServiceFullWebRequestConditionsCondition... conditions) {
            return conditions(List.of(conditions));
        }
        public ServiceFullWebRequestConditions build() {
            final var o = new ServiceFullWebRequestConditions();
            o.conditions = conditions;
            return o;
        }
    }
}