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

    public sealed class XmattersNotificationHeadersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("headers", required: true)]
        private InputList<Inputs.XmattersNotificationHeadersHeaderGetArgs>? _headers;

        /// <summary>
        /// An additional HTTP Header to include when sending requests
        /// </summary>
        public InputList<Inputs.XmattersNotificationHeadersHeaderGetArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.XmattersNotificationHeadersHeaderGetArgs>());
            set => _headers = value;
        }

        public XmattersNotificationHeadersGetArgs()
        {
        }
        public static new XmattersNotificationHeadersGetArgs Empty => new XmattersNotificationHeadersGetArgs();
    }
}
