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


public final class HostAnomaliesV2HostConnectionLostDetectionArgs extends com.pulumi.resources.ResourceArgs {

    public static final HostAnomaliesV2HostConnectionLostDetectionArgs Empty = new HostAnomaliesV2HostConnectionLostDetectionArgs();

    @Import(name="enabled", required=true)
    private Output<Boolean> enabled;

    public Output<Boolean> enabled() {
        return this.enabled;
    }

    @Import(name="onGracefulShutdowns")
    private @Nullable Output<String> onGracefulShutdowns;

    public Optional<Output<String>> onGracefulShutdowns() {
        return Optional.ofNullable(this.onGracefulShutdowns);
    }

    private HostAnomaliesV2HostConnectionLostDetectionArgs() {}

    private HostAnomaliesV2HostConnectionLostDetectionArgs(HostAnomaliesV2HostConnectionLostDetectionArgs $) {
        this.enabled = $.enabled;
        this.onGracefulShutdowns = $.onGracefulShutdowns;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(HostAnomaliesV2HostConnectionLostDetectionArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private HostAnomaliesV2HostConnectionLostDetectionArgs $;

        public Builder() {
            $ = new HostAnomaliesV2HostConnectionLostDetectionArgs();
        }

        public Builder(HostAnomaliesV2HostConnectionLostDetectionArgs defaults) {
            $ = new HostAnomaliesV2HostConnectionLostDetectionArgs(Objects.requireNonNull(defaults));
        }

        public Builder enabled(Output<Boolean> enabled) {
            $.enabled = enabled;
            return this;
        }

        public Builder enabled(Boolean enabled) {
            return enabled(Output.of(enabled));
        }

        public Builder onGracefulShutdowns(@Nullable Output<String> onGracefulShutdowns) {
            $.onGracefulShutdowns = onGracefulShutdowns;
            return this;
        }

        public Builder onGracefulShutdowns(String onGracefulShutdowns) {
            return onGracefulShutdowns(Output.of(onGracefulShutdowns));
        }

        public HostAnomaliesV2HostConnectionLostDetectionArgs build() {
            $.enabled = Objects.requireNonNull($.enabled, "expected parameter 'enabled' to be non-null");
            return $;
        }
    }

}