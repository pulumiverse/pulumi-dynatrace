// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class OneagentUpdatesMaintenanceWindowsMaintenanceWindowGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select a [maintenance window for OneAgent updates](https://www.terraform.io/ui/settings/builtin:deployment.management.update-windows)
        /// </summary>
        [Input("maintenanceWindow", required: true)]
        public Input<string> MaintenanceWindow { get; set; } = null!;

        public OneagentUpdatesMaintenanceWindowsMaintenanceWindowGetArgs()
        {
        }
        public static new OneagentUpdatesMaintenanceWindowsMaintenanceWindowGetArgs Empty => new OneagentUpdatesMaintenanceWindowsMaintenanceWindowGetArgs();
    }
}