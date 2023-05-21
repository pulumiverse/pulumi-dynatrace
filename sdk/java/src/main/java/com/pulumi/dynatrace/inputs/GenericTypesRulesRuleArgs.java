// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.GenericTypesRulesRuleAttributesArgs;
import com.pulumi.dynatrace.inputs.GenericTypesRulesRuleRequiredDimensionsArgs;
import com.pulumi.dynatrace.inputs.GenericTypesRulesRuleSourcesArgs;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GenericTypesRulesRuleArgs extends com.pulumi.resources.ResourceArgs {

    public static final GenericTypesRulesRuleArgs Empty = new GenericTypesRulesRuleArgs();

    @Import(name="attributes")
    private @Nullable Output<GenericTypesRulesRuleAttributesArgs> attributes;

    public Optional<Output<GenericTypesRulesRuleAttributesArgs>> attributes() {
        return Optional.ofNullable(this.attributes);
    }

    @Import(name="iconPattern")
    private @Nullable Output<String> iconPattern;

    public Optional<Output<String>> iconPattern() {
        return Optional.ofNullable(this.iconPattern);
    }

    @Import(name="idPattern", required=true)
    private Output<String> idPattern;

    public Output<String> idPattern() {
        return this.idPattern;
    }

    @Import(name="instanceNamePattern")
    private @Nullable Output<String> instanceNamePattern;

    public Optional<Output<String>> instanceNamePattern() {
        return Optional.ofNullable(this.instanceNamePattern);
    }

    @Import(name="requiredDimensions")
    private @Nullable Output<GenericTypesRulesRuleRequiredDimensionsArgs> requiredDimensions;

    public Optional<Output<GenericTypesRulesRuleRequiredDimensionsArgs>> requiredDimensions() {
        return Optional.ofNullable(this.requiredDimensions);
    }

    @Import(name="role")
    private @Nullable Output<String> role;

    public Optional<Output<String>> role() {
        return Optional.ofNullable(this.role);
    }

    @Import(name="sources", required=true)
    private Output<GenericTypesRulesRuleSourcesArgs> sources;

    public Output<GenericTypesRulesRuleSourcesArgs> sources() {
        return this.sources;
    }

    private GenericTypesRulesRuleArgs() {}

    private GenericTypesRulesRuleArgs(GenericTypesRulesRuleArgs $) {
        this.attributes = $.attributes;
        this.iconPattern = $.iconPattern;
        this.idPattern = $.idPattern;
        this.instanceNamePattern = $.instanceNamePattern;
        this.requiredDimensions = $.requiredDimensions;
        this.role = $.role;
        this.sources = $.sources;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GenericTypesRulesRuleArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GenericTypesRulesRuleArgs $;

        public Builder() {
            $ = new GenericTypesRulesRuleArgs();
        }

        public Builder(GenericTypesRulesRuleArgs defaults) {
            $ = new GenericTypesRulesRuleArgs(Objects.requireNonNull(defaults));
        }

        public Builder attributes(@Nullable Output<GenericTypesRulesRuleAttributesArgs> attributes) {
            $.attributes = attributes;
            return this;
        }

        public Builder attributes(GenericTypesRulesRuleAttributesArgs attributes) {
            return attributes(Output.of(attributes));
        }

        public Builder iconPattern(@Nullable Output<String> iconPattern) {
            $.iconPattern = iconPattern;
            return this;
        }

        public Builder iconPattern(String iconPattern) {
            return iconPattern(Output.of(iconPattern));
        }

        public Builder idPattern(Output<String> idPattern) {
            $.idPattern = idPattern;
            return this;
        }

        public Builder idPattern(String idPattern) {
            return idPattern(Output.of(idPattern));
        }

        public Builder instanceNamePattern(@Nullable Output<String> instanceNamePattern) {
            $.instanceNamePattern = instanceNamePattern;
            return this;
        }

        public Builder instanceNamePattern(String instanceNamePattern) {
            return instanceNamePattern(Output.of(instanceNamePattern));
        }

        public Builder requiredDimensions(@Nullable Output<GenericTypesRulesRuleRequiredDimensionsArgs> requiredDimensions) {
            $.requiredDimensions = requiredDimensions;
            return this;
        }

        public Builder requiredDimensions(GenericTypesRulesRuleRequiredDimensionsArgs requiredDimensions) {
            return requiredDimensions(Output.of(requiredDimensions));
        }

        public Builder role(@Nullable Output<String> role) {
            $.role = role;
            return this;
        }

        public Builder role(String role) {
            return role(Output.of(role));
        }

        public Builder sources(Output<GenericTypesRulesRuleSourcesArgs> sources) {
            $.sources = sources;
            return this;
        }

        public Builder sources(GenericTypesRulesRuleSourcesArgs sources) {
            return sources(Output.of(sources));
        }

        public GenericTypesRulesRuleArgs build() {
            $.idPattern = Objects.requireNonNull($.idPattern, "expected parameter 'idPattern' to be non-null");
            $.sources = Objects.requireNonNull($.sources, "expected parameter 'sources' to be non-null");
            return $;
        }
    }

}