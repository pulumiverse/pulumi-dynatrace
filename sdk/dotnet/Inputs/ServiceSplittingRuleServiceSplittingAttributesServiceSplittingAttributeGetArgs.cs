// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class ServiceSplittingRuleServiceSplittingAttributesServiceSplittingAttributeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attribute key
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        public ServiceSplittingRuleServiceSplittingAttributesServiceSplittingAttributeGetArgs()
        {
        }
        public static new ServiceSplittingRuleServiceSplittingAttributesServiceSplittingAttributeGetArgs Empty => new ServiceSplittingRuleServiceSplittingAttributesServiceSplittingAttributeGetArgs();
    }
}
