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

    public sealed class AppMonitoringAppMonitoringArgs : global::Pulumi.ResourceArgs
    {
        [Input("appMonitorings", required: true)]
        private InputList<Inputs.AppMonitoringAppMonitoringAppMonitoringArgs>? _appMonitorings;
        public InputList<Inputs.AppMonitoringAppMonitoringAppMonitoringArgs> AppMonitorings
        {
            get => _appMonitorings ?? (_appMonitorings = new InputList<Inputs.AppMonitoringAppMonitoringAppMonitoringArgs>());
            set => _appMonitorings = value;
        }

        public AppMonitoringAppMonitoringArgs()
        {
        }
        public static new AppMonitoringAppMonitoringArgs Empty => new AppMonitoringAppMonitoringArgs();
    }
}
