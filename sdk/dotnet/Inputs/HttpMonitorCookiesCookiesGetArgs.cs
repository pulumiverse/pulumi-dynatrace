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

    public sealed class HttpMonitorCookiesCookiesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cookies", required: true)]
        private InputList<Inputs.HttpMonitorCookiesCookiesCookieGetArgs>? _cookies;
        public InputList<Inputs.HttpMonitorCookiesCookiesCookieGetArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.HttpMonitorCookiesCookiesCookieGetArgs>());
            set => _cookies = value;
        }

        public HttpMonitorCookiesCookiesGetArgs()
        {
        }
        public static new HttpMonitorCookiesCookiesGetArgs Empty => new HttpMonitorCookiesCookiesGetArgs();
    }
}
