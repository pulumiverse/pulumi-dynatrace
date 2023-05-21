// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class OneagentDefaultVersionState extends com.pulumi.resources.ResourceArgs {

    public static final OneagentDefaultVersionState Empty = new OneagentDefaultVersionState();

    /**
     * Default version
     * 
     */
    @Import(name="defaultVersion")
    private @Nullable Output<String> defaultVersion;

    /**
     * @return Default version
     * 
     */
    public Optional<Output<String>> defaultVersion() {
        return Optional.ofNullable(this.defaultVersion);
    }

    /**
     * Revision
     * 
     */
    @Import(name="revision")
    private @Nullable Output<String> revision;

    /**
     * @return Revision
     * 
     */
    public Optional<Output<String>> revision() {
        return Optional.ofNullable(this.revision);
    }

    private OneagentDefaultVersionState() {}

    private OneagentDefaultVersionState(OneagentDefaultVersionState $) {
        this.defaultVersion = $.defaultVersion;
        this.revision = $.revision;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(OneagentDefaultVersionState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private OneagentDefaultVersionState $;

        public Builder() {
            $ = new OneagentDefaultVersionState();
        }

        public Builder(OneagentDefaultVersionState defaults) {
            $ = new OneagentDefaultVersionState(Objects.requireNonNull(defaults));
        }

        /**
         * @param defaultVersion Default version
         * 
         * @return builder
         * 
         */
        public Builder defaultVersion(@Nullable Output<String> defaultVersion) {
            $.defaultVersion = defaultVersion;
            return this;
        }

        /**
         * @param defaultVersion Default version
         * 
         * @return builder
         * 
         */
        public Builder defaultVersion(String defaultVersion) {
            return defaultVersion(Output.of(defaultVersion));
        }

        /**
         * @param revision Revision
         * 
         * @return builder
         * 
         */
        public Builder revision(@Nullable Output<String> revision) {
            $.revision = revision;
            return this;
        }

        /**
         * @param revision Revision
         * 
         * @return builder
         * 
         */
        public Builder revision(String revision) {
            return revision(Output.of(revision));
        }

        public OneagentDefaultVersionState build() {
            return $;
        }
    }

}