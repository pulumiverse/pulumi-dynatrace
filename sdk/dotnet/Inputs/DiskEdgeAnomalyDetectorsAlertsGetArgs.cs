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

    public sealed class DiskEdgeAnomalyDetectorsAlertsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("alerts", required: true)]
        private InputList<Inputs.DiskEdgeAnomalyDetectorsAlertsAlertGetArgs>? _alerts;
        public InputList<Inputs.DiskEdgeAnomalyDetectorsAlertsAlertGetArgs> Alerts
        {
            get => _alerts ?? (_alerts = new InputList<Inputs.DiskEdgeAnomalyDetectorsAlertsAlertGetArgs>());
            set => _alerts = value;
        }

        public DiskEdgeAnomalyDetectorsAlertsGetArgs()
        {
        }
        public static new DiskEdgeAnomalyDetectorsAlertsGetArgs Empty => new DiskEdgeAnomalyDetectorsAlertsGetArgs();
    }
}