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

    public sealed class MaintenanceFiltersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters", required: true)]
        private InputList<Inputs.MaintenanceFiltersFilterGetArgs>? _filters;
        public InputList<Inputs.MaintenanceFiltersFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.MaintenanceFiltersFilterGetArgs>());
            set => _filters = value;
        }

        public MaintenanceFiltersGetArgs()
        {
        }
        public static new MaintenanceFiltersGetArgs Empty => new MaintenanceFiltersGetArgs();
    }
}
