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

    public sealed class RequestAttributeDataSourceMethodArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The index of the argument to capture. Set `0` to capture the return value, `1` or higher to capture a mehtod argument.   Required if the **capture** is set to `ARGUMENT`.  Not applicable in other cases
        /// </summary>
        [Input("argumentIndex")]
        public Input<int>? ArgumentIndex { get; set; }

        /// <summary>
        /// What to capture from the method
        /// </summary>
        [Input("capture", required: true)]
        public Input<string> Capture { get; set; } = null!;

        /// <summary>
        /// The getter chain to apply to the captured object. It is required in one of the following cases:  The **capture** is set to `THIS`.    The **capture** is set to `ARGUMENT`, and the argument is not a primitive, a primitive wrapper class, a string, or an array.   Not applicable in other cases
        /// </summary>
        [Input("deepObjectAccess")]
        public Input<string>? DeepObjectAccess { get; set; }

        /// <summary>
        /// Configuration of a method to be captured
        /// </summary>
        [Input("method")]
        public Input<Inputs.RequestAttributeDataSourceMethodMethodArgs>? Method { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public RequestAttributeDataSourceMethodArgs()
        {
        }
        public static new RequestAttributeDataSourceMethodArgs Empty => new RequestAttributeDataSourceMethodArgs();
    }
}
