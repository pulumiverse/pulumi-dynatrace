// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class WebApplicationWaterfallSettings
    {
        /// <summary>
        /// Warn about resources with a lower browser cache rate above *X*%. Values between 1 and 100 are allowed.
        /// </summary>
        public readonly int ResourceBrowserCachingThreshold;
        /// <summary>
        /// Warn about resources larger than *X* bytes. Values between 0 and 99999000 are allowed.
        /// </summary>
        public readonly int ResourcesThreshold;
        /// <summary>
        /// Warn about slow CDN resources with a response time above *X* ms. Values between 0 and 99999000 are allowed.
        /// </summary>
        public readonly int SlowCndResourcesThreshold;
        /// <summary>
        /// Warn about slow 1st party resources with a response time above *X* ms. Values between 0 and 99999000 are allowed.
        /// </summary>
        public readonly int SlowFirstPartyResourcesThreshold;
        /// <summary>
        /// Warn about slow 3rd party resources with a response time above *X* ms. Values between 0 and 99999000 are allowed.
        /// </summary>
        public readonly int SlowThirdPartyResourcesThreshold;
        /// <summary>
        /// Warn if Speed index exceeds *X* % of Visually complete. Values between 1 and 99 are allowed.
        /// </summary>
        public readonly int SpeedIndexVisuallyCompleteRatioThreshold;
        /// <summary>
        /// Warn about uncompressed resources larger than *X* bytes. Values between 0 and 99999 are allowed.
        /// </summary>
        public readonly int UncompressedResourcesThreshold;

        [OutputConstructor]
        private WebApplicationWaterfallSettings(
            int resourceBrowserCachingThreshold,

            int resourcesThreshold,

            int slowCndResourcesThreshold,

            int slowFirstPartyResourcesThreshold,

            int slowThirdPartyResourcesThreshold,

            int speedIndexVisuallyCompleteRatioThreshold,

            int uncompressedResourcesThreshold)
        {
            ResourceBrowserCachingThreshold = resourceBrowserCachingThreshold;
            ResourcesThreshold = resourcesThreshold;
            SlowCndResourcesThreshold = slowCndResourcesThreshold;
            SlowFirstPartyResourcesThreshold = slowFirstPartyResourcesThreshold;
            SlowThirdPartyResourcesThreshold = slowThirdPartyResourcesThreshold;
            SpeedIndexVisuallyCompleteRatioThreshold = speedIndexVisuallyCompleteRatioThreshold;
            UncompressedResourcesThreshold = uncompressedResourcesThreshold;
        }
    }
}