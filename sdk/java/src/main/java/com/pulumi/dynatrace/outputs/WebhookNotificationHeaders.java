// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.dynatrace.outputs.WebhookNotificationHeadersHeader;
import java.util.List;
import java.util.Objects;

@CustomType
public final class WebhookNotificationHeaders {
    /**
     * @return An additional HTTP Header to include when sending requests
     * 
     */
    private List<WebhookNotificationHeadersHeader> headers;

    private WebhookNotificationHeaders() {}
    /**
     * @return An additional HTTP Header to include when sending requests
     * 
     */
    public List<WebhookNotificationHeadersHeader> headers() {
        return this.headers;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(WebhookNotificationHeaders defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private List<WebhookNotificationHeadersHeader> headers;
        public Builder() {}
        public Builder(WebhookNotificationHeaders defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.headers = defaults.headers;
        }

        @CustomType.Setter
        public Builder headers(List<WebhookNotificationHeadersHeader> headers) {
            this.headers = Objects.requireNonNull(headers);
            return this;
        }
        public Builder headers(WebhookNotificationHeadersHeader... headers) {
            return headers(List.of(headers));
        }
        public WebhookNotificationHeaders build() {
            final var o = new WebhookNotificationHeaders();
            o.headers = headers;
            return o;
        }
    }
}