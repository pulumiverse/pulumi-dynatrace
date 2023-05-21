// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.WebAppRequestErrorsErrorRulesArgs;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class WebAppRequestErrorsState extends com.pulumi.resources.ResourceArgs {

    public static final WebAppRequestErrorsState Empty = new WebAppRequestErrorsState();

    /**
     * (Field has overlap with `dynatrace.ApplicationErrorRules`)
     * 
     */
    @Import(name="errorRules")
    private @Nullable Output<WebAppRequestErrorsErrorRulesArgs> errorRules;

    /**
     * @return (Field has overlap with `dynatrace.ApplicationErrorRules`)
     * 
     */
    public Optional<Output<WebAppRequestErrorsErrorRulesArgs>> errorRules() {
        return Optional.ofNullable(this.errorRules);
    }

    /**
     * (Field has overlap with `dynatrace.ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
     * 
     */
    @Import(name="ignoreRequestErrorsInApdexCalculation")
    private @Nullable Output<Boolean> ignoreRequestErrorsInApdexCalculation;

    /**
     * @return (Field has overlap with `dynatrace.ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
     * 
     */
    public Optional<Output<Boolean>> ignoreRequestErrorsInApdexCalculation() {
        return Optional.ofNullable(this.ignoreRequestErrorsInApdexCalculation);
    }

    /**
     * The scope of this setting (APPLICATION)
     * 
     */
    @Import(name="scope")
    private @Nullable Output<String> scope;

    /**
     * @return The scope of this setting (APPLICATION)
     * 
     */
    public Optional<Output<String>> scope() {
        return Optional.ofNullable(this.scope);
    }

    private WebAppRequestErrorsState() {}

    private WebAppRequestErrorsState(WebAppRequestErrorsState $) {
        this.errorRules = $.errorRules;
        this.ignoreRequestErrorsInApdexCalculation = $.ignoreRequestErrorsInApdexCalculation;
        this.scope = $.scope;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(WebAppRequestErrorsState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private WebAppRequestErrorsState $;

        public Builder() {
            $ = new WebAppRequestErrorsState();
        }

        public Builder(WebAppRequestErrorsState defaults) {
            $ = new WebAppRequestErrorsState(Objects.requireNonNull(defaults));
        }

        /**
         * @param errorRules (Field has overlap with `dynatrace.ApplicationErrorRules`)
         * 
         * @return builder
         * 
         */
        public Builder errorRules(@Nullable Output<WebAppRequestErrorsErrorRulesArgs> errorRules) {
            $.errorRules = errorRules;
            return this;
        }

        /**
         * @param errorRules (Field has overlap with `dynatrace.ApplicationErrorRules`)
         * 
         * @return builder
         * 
         */
        public Builder errorRules(WebAppRequestErrorsErrorRulesArgs errorRules) {
            return errorRules(Output.of(errorRules));
        }

        /**
         * @param ignoreRequestErrorsInApdexCalculation (Field has overlap with `dynatrace.ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
         * 
         * @return builder
         * 
         */
        public Builder ignoreRequestErrorsInApdexCalculation(@Nullable Output<Boolean> ignoreRequestErrorsInApdexCalculation) {
            $.ignoreRequestErrorsInApdexCalculation = ignoreRequestErrorsInApdexCalculation;
            return this;
        }

        /**
         * @param ignoreRequestErrorsInApdexCalculation (Field has overlap with `dynatrace.ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
         * 
         * @return builder
         * 
         */
        public Builder ignoreRequestErrorsInApdexCalculation(Boolean ignoreRequestErrorsInApdexCalculation) {
            return ignoreRequestErrorsInApdexCalculation(Output.of(ignoreRequestErrorsInApdexCalculation));
        }

        /**
         * @param scope The scope of this setting (APPLICATION)
         * 
         * @return builder
         * 
         */
        public Builder scope(@Nullable Output<String> scope) {
            $.scope = scope;
            return this;
        }

        /**
         * @param scope The scope of this setting (APPLICATION)
         * 
         * @return builder
         * 
         */
        public Builder scope(String scope) {
            return scope(Output.of(scope));
        }

        public WebAppRequestErrorsState build() {
            return $;
        }
    }

}