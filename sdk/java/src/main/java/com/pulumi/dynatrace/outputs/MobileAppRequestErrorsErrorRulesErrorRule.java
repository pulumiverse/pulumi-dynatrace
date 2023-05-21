// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.Objects;

@CustomType
public final class MobileAppRequestErrorsErrorRulesErrorRule {
    private String errorCodes;

    private MobileAppRequestErrorsErrorRulesErrorRule() {}
    public String errorCodes() {
        return this.errorCodes;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(MobileAppRequestErrorsErrorRulesErrorRule defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String errorCodes;
        public Builder() {}
        public Builder(MobileAppRequestErrorsErrorRulesErrorRule defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.errorCodes = defaults.errorCodes;
        }

        @CustomType.Setter
        public Builder errorCodes(String errorCodes) {
            this.errorCodes = Objects.requireNonNull(errorCodes);
            return this;
        }
        public MobileAppRequestErrorsErrorRulesErrorRule build() {
            final var o = new MobileAppRequestErrorsErrorRulesErrorRule();
            o.errorCodes = errorCodes;
            return o;
        }
    }
}