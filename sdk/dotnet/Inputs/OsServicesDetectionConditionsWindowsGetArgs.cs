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

    public sealed class OsServicesDetectionConditionsWindowsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("detectionConditionsWindows", required: true)]
        private InputList<Inputs.OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs>? _detectionConditionsWindows;
        public InputList<Inputs.OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs> DetectionConditionsWindows
        {
            get => _detectionConditionsWindows ?? (_detectionConditionsWindows = new InputList<Inputs.OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs>());
            set => _detectionConditionsWindows = value;
        }

        public OsServicesDetectionConditionsWindowsGetArgs()
        {
        }
        public static new OsServicesDetectionConditionsWindowsGetArgs Empty => new OsServicesDetectionConditionsWindowsGetArgs();
    }
}
