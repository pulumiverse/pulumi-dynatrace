// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class DatabaseAnomaliesV2ResponseTimeAutoDetectionOverAlertingProtectionArgs : global::Pulumi.ResourceArgs
    {
        [Input("minutesAbnormalState", required: true)]
        public Input<int> MinutesAbnormalState { get; set; } = null!;

        [Input("requestsPerMinute", required: true)]
        public Input<double> RequestsPerMinute { get; set; } = null!;

        public DatabaseAnomaliesV2ResponseTimeAutoDetectionOverAlertingProtectionArgs()
        {
        }
        public static new DatabaseAnomaliesV2ResponseTimeAutoDetectionOverAlertingProtectionArgs Empty => new DatabaseAnomaliesV2ResponseTimeAutoDetectionOverAlertingProtectionArgs();
    }
}