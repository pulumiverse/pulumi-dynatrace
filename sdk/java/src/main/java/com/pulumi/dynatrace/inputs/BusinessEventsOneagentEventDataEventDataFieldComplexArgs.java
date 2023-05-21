// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.BusinessEventsOneagentEventDataEventDataFieldComplexSourceArgs;
import java.lang.String;
import java.util.Objects;


public final class BusinessEventsOneagentEventDataEventDataFieldComplexArgs extends com.pulumi.resources.ResourceArgs {

    public static final BusinessEventsOneagentEventDataEventDataFieldComplexArgs Empty = new BusinessEventsOneagentEventDataEventDataFieldComplexArgs();

    @Import(name="name", required=true)
    private Output<String> name;

    public Output<String> name() {
        return this.name;
    }

    @Import(name="source", required=true)
    private Output<BusinessEventsOneagentEventDataEventDataFieldComplexSourceArgs> source;

    public Output<BusinessEventsOneagentEventDataEventDataFieldComplexSourceArgs> source() {
        return this.source;
    }

    private BusinessEventsOneagentEventDataEventDataFieldComplexArgs() {}

    private BusinessEventsOneagentEventDataEventDataFieldComplexArgs(BusinessEventsOneagentEventDataEventDataFieldComplexArgs $) {
        this.name = $.name;
        this.source = $.source;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(BusinessEventsOneagentEventDataEventDataFieldComplexArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private BusinessEventsOneagentEventDataEventDataFieldComplexArgs $;

        public Builder() {
            $ = new BusinessEventsOneagentEventDataEventDataFieldComplexArgs();
        }

        public Builder(BusinessEventsOneagentEventDataEventDataFieldComplexArgs defaults) {
            $ = new BusinessEventsOneagentEventDataEventDataFieldComplexArgs(Objects.requireNonNull(defaults));
        }

        public Builder name(Output<String> name) {
            $.name = name;
            return this;
        }

        public Builder name(String name) {
            return name(Output.of(name));
        }

        public Builder source(Output<BusinessEventsOneagentEventDataEventDataFieldComplexSourceArgs> source) {
            $.source = source;
            return this;
        }

        public Builder source(BusinessEventsOneagentEventDataEventDataFieldComplexSourceArgs source) {
            return source(Output.of(source));
        }

        public BusinessEventsOneagentEventDataEventDataFieldComplexArgs build() {
            $.name = Objects.requireNonNull($.name, "expected parameter 'name' to be non-null");
            $.source = Objects.requireNonNull($.source, "expected parameter 'source' to be non-null");
            return $;
        }
    }

}