// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class OneagentFeaturesState extends com.pulumi.resources.ResourceArgs {

    public static final OneagentFeaturesState Empty = new OneagentFeaturesState();

    /**
     * Used internally by the terraform provider. Do not populate
     * 
     */
    @Import(name="_restore_")
    private @Nullable Output<String> _restore_;

    /**
     * @return Used internally by the terraform provider. Do not populate
     * 
     */
    public Optional<Output<String>> _restore_() {
        return Optional.ofNullable(this._restore_);
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="enabled")
    private @Nullable Output<Boolean> enabled;

    /**
     * @return This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    public Optional<Output<Boolean>> enabled() {
        return Optional.ofNullable(this.enabled);
    }

    /**
     * Activate this feature also in OneAgents only fulfilling the minimum Opt-In version
     * 
     */
    @Import(name="forcible")
    private @Nullable Output<Boolean> forcible;

    /**
     * @return Activate this feature also in OneAgents only fulfilling the minimum Opt-In version
     * 
     */
    public Optional<Output<Boolean>> forcible() {
        return Optional.ofNullable(this.forcible);
    }

    /**
     * Instrumentation enabled (change needs a process restart)
     * 
     */
    @Import(name="instrumentation")
    private @Nullable Output<Boolean> instrumentation;

    /**
     * @return Instrumentation enabled (change needs a process restart)
     * 
     */
    public Optional<Output<Boolean>> instrumentation() {
        return Optional.ofNullable(this.instrumentation);
    }

    /**
     * Feature
     * 
     */
    @Import(name="key")
    private @Nullable Output<String> key;

    /**
     * @return Feature
     * 
     */
    public Optional<Output<String>> key() {
        return Optional.ofNullable(this.key);
    }

    /**
     * The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
     * 
     */
    @Import(name="scope")
    private @Nullable Output<String> scope;

    /**
     * @return The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
     * 
     */
    public Optional<Output<String>> scope() {
        return Optional.ofNullable(this.scope);
    }

    private OneagentFeaturesState() {}

    private OneagentFeaturesState(OneagentFeaturesState $) {
        this._restore_ = $._restore_;
        this.enabled = $.enabled;
        this.forcible = $.forcible;
        this.instrumentation = $.instrumentation;
        this.key = $.key;
        this.scope = $.scope;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(OneagentFeaturesState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private OneagentFeaturesState $;

        public Builder() {
            $ = new OneagentFeaturesState();
        }

        public Builder(OneagentFeaturesState defaults) {
            $ = new OneagentFeaturesState(Objects.requireNonNull(defaults));
        }

        /**
         * @param _restore_ Used internally by the terraform provider. Do not populate
         * 
         * @return builder
         * 
         */
        public Builder _restore_(@Nullable Output<String> _restore_) {
            $._restore_ = _restore_;
            return this;
        }

        /**
         * @param _restore_ Used internally by the terraform provider. Do not populate
         * 
         * @return builder
         * 
         */
        public Builder _restore_(String _restore_) {
            return _restore_(Output.of(_restore_));
        }

        /**
         * @param enabled This setting is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder enabled(@Nullable Output<Boolean> enabled) {
            $.enabled = enabled;
            return this;
        }

        /**
         * @param enabled This setting is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder enabled(Boolean enabled) {
            return enabled(Output.of(enabled));
        }

        /**
         * @param forcible Activate this feature also in OneAgents only fulfilling the minimum Opt-In version
         * 
         * @return builder
         * 
         */
        public Builder forcible(@Nullable Output<Boolean> forcible) {
            $.forcible = forcible;
            return this;
        }

        /**
         * @param forcible Activate this feature also in OneAgents only fulfilling the minimum Opt-In version
         * 
         * @return builder
         * 
         */
        public Builder forcible(Boolean forcible) {
            return forcible(Output.of(forcible));
        }

        /**
         * @param instrumentation Instrumentation enabled (change needs a process restart)
         * 
         * @return builder
         * 
         */
        public Builder instrumentation(@Nullable Output<Boolean> instrumentation) {
            $.instrumentation = instrumentation;
            return this;
        }

        /**
         * @param instrumentation Instrumentation enabled (change needs a process restart)
         * 
         * @return builder
         * 
         */
        public Builder instrumentation(Boolean instrumentation) {
            return instrumentation(Output.of(instrumentation));
        }

        /**
         * @param key Feature
         * 
         * @return builder
         * 
         */
        public Builder key(@Nullable Output<String> key) {
            $.key = key;
            return this;
        }

        /**
         * @param key Feature
         * 
         * @return builder
         * 
         */
        public Builder key(String key) {
            return key(Output.of(key));
        }

        /**
         * @param scope The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
         * 
         * @return builder
         * 
         */
        public Builder scope(@Nullable Output<String> scope) {
            $.scope = scope;
            return this;
        }

        /**
         * @param scope The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
         * 
         * @return builder
         * 
         */
        public Builder scope(String scope) {
            return scope(Output.of(scope));
        }

        public OneagentFeaturesState build() {
            return $;
        }
    }

}