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
    public sealed class HostAnomaliesDisksInodesThresholds
    {
        /// <summary>
        /// Alert if percentage of available inodes is lower than *X*% in 3 out of 5 samples
        /// </summary>
        public readonly int Percentage;

        [OutputConstructor]
        private HostAnomaliesDisksInodesThresholds(int percentage)
        {
            Percentage = percentage;
        }
    }
}
