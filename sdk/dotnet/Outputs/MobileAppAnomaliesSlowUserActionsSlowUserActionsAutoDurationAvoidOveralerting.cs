// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralerting
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly int MinActionRate;

        [OutputConstructor]
        private MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralerting(int minActionRate)
        {
            MinActionRate = minActionRate;
        }
    }
}
