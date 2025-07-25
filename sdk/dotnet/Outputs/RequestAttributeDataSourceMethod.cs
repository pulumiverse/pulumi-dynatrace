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
    public sealed class RequestAttributeDataSourceMethod
    {
        /// <summary>
        /// The index of the argument to capture. Set `0` to capture the return value, `1` or higher to capture a mehtod argument.   Required if the **capture** is set to `ARGUMENT`.  Not applicable in other cases
        /// </summary>
        public readonly int? ArgumentIndex;
        /// <summary>
        /// What to capture from the method
        /// </summary>
        public readonly string Capture;
        /// <summary>
        /// The getter chain to apply to the captured object. It is required in one of the following cases:  The **capture** is set to `THIS`.    The **capture** is set to `ARGUMENT`, and the argument is not a primitive, a primitive wrapper class, a string, or an array.   Not applicable in other cases
        /// </summary>
        public readonly string? DeepObjectAccess;
        /// <summary>
        /// Configuration of a method to be captured
        /// </summary>
        public readonly Outputs.RequestAttributeDataSourceMethodMethod? Method;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private RequestAttributeDataSourceMethod(
            int? argumentIndex,

            string capture,

            string? deepObjectAccess,

            Outputs.RequestAttributeDataSourceMethodMethod? method,

            string? unknowns)
        {
            ArgumentIndex = argumentIndex;
            Capture = capture;
            DeepObjectAccess = deepObjectAccess;
            Method = method;
            Unknowns = unknowns;
        }
    }
}
