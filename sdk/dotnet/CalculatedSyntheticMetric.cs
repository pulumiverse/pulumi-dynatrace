// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/calculatedSyntheticMetric:CalculatedSyntheticMetric")]
    public partial class CalculatedSyntheticMetric : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Descriptor of a calculated synthetic metric.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Dimension of the calculated synthetic metric.
        /// </summary>
        [Output("dimensions")]
        public Output<ImmutableArray<Outputs.CalculatedSyntheticMetricDimension>> Dimensions { get; private set; } = null!;

        /// <summary>
        /// The metric is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Filter of the calculated synthetic metric.
        /// </summary>
        [Output("filter")]
        public Output<Outputs.CalculatedSyntheticMetricFilter?> Filter { get; private set; } = null!;

        /// <summary>
        /// The type of the synthetic metric. Possible values: [ ApplicationCache, Callback, CumulativeLayoutShift, DNSLookup, DOMComplete, DOMContentLoaded, DOMInteractive, FailedRequestsResources, FirstContentfulPaint, FirstInputDelay, FirstInputStart, FirstPaint, HTMLDownloaded, HttpErrors, JavaScriptErrors, LargestContentfulPaint, LoadEventEnd, LoadEventStart, LongTasks, NavigationStart, OnDOMContentLoaded, OnLoad, Processing, RedirectTime, Request, RequestStart, ResourceCount, Response, SecureConnect, SpeedIndex, TCPConnect, TimeToFirstByte, TotalDuration, TransferSize, UserActionDuration, VisuallyComplete ]
        /// </summary>
        [Output("metric")]
        public Output<string> Metric { get; private set; } = null!;

        /// <summary>
        /// The unique key of the calculated synthetic metric.
        /// </summary>
        [Output("metricKey")]
        public Output<string> MetricKey { get; private set; } = null!;

        /// <summary>
        /// The Dynatrace entity ID of the monitor to which the metric belongs.
        /// </summary>
        [Output("monitorIdentifier")]
        public Output<string> MonitorIdentifier { get; private set; } = null!;

        /// <summary>
        /// The displayed name of the metric.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a CalculatedSyntheticMetric resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CalculatedSyntheticMetric(string name, CalculatedSyntheticMetricArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/calculatedSyntheticMetric:CalculatedSyntheticMetric", name, args ?? new CalculatedSyntheticMetricArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CalculatedSyntheticMetric(string name, Input<string> id, CalculatedSyntheticMetricState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/calculatedSyntheticMetric:CalculatedSyntheticMetric", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CalculatedSyntheticMetric resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CalculatedSyntheticMetric Get(string name, Input<string> id, CalculatedSyntheticMetricState? state = null, CustomResourceOptions? options = null)
        {
            return new CalculatedSyntheticMetric(name, id, state, options);
        }
    }

    public sealed class CalculatedSyntheticMetricArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Descriptor of a calculated synthetic metric.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dimensions")]
        private InputList<Inputs.CalculatedSyntheticMetricDimensionArgs>? _dimensions;

        /// <summary>
        /// Dimension of the calculated synthetic metric.
        /// </summary>
        public InputList<Inputs.CalculatedSyntheticMetricDimensionArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.CalculatedSyntheticMetricDimensionArgs>());
            set => _dimensions = value;
        }

        /// <summary>
        /// The metric is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Filter of the calculated synthetic metric.
        /// </summary>
        [Input("filter")]
        public Input<Inputs.CalculatedSyntheticMetricFilterArgs>? Filter { get; set; }

        /// <summary>
        /// The type of the synthetic metric. Possible values: [ ApplicationCache, Callback, CumulativeLayoutShift, DNSLookup, DOMComplete, DOMContentLoaded, DOMInteractive, FailedRequestsResources, FirstContentfulPaint, FirstInputDelay, FirstInputStart, FirstPaint, HTMLDownloaded, HttpErrors, JavaScriptErrors, LargestContentfulPaint, LoadEventEnd, LoadEventStart, LongTasks, NavigationStart, OnDOMContentLoaded, OnLoad, Processing, RedirectTime, Request, RequestStart, ResourceCount, Response, SecureConnect, SpeedIndex, TCPConnect, TimeToFirstByte, TotalDuration, TransferSize, UserActionDuration, VisuallyComplete ]
        /// </summary>
        [Input("metric", required: true)]
        public Input<string> Metric { get; set; } = null!;

        /// <summary>
        /// The unique key of the calculated synthetic metric.
        /// </summary>
        [Input("metricKey", required: true)]
        public Input<string> MetricKey { get; set; } = null!;

        /// <summary>
        /// The Dynatrace entity ID of the monitor to which the metric belongs.
        /// </summary>
        [Input("monitorIdentifier", required: true)]
        public Input<string> MonitorIdentifier { get; set; } = null!;

        /// <summary>
        /// The displayed name of the metric.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public CalculatedSyntheticMetricArgs()
        {
        }
        public static new CalculatedSyntheticMetricArgs Empty => new CalculatedSyntheticMetricArgs();
    }

    public sealed class CalculatedSyntheticMetricState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Descriptor of a calculated synthetic metric.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dimensions")]
        private InputList<Inputs.CalculatedSyntheticMetricDimensionGetArgs>? _dimensions;

        /// <summary>
        /// Dimension of the calculated synthetic metric.
        /// </summary>
        public InputList<Inputs.CalculatedSyntheticMetricDimensionGetArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.CalculatedSyntheticMetricDimensionGetArgs>());
            set => _dimensions = value;
        }

        /// <summary>
        /// The metric is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Filter of the calculated synthetic metric.
        /// </summary>
        [Input("filter")]
        public Input<Inputs.CalculatedSyntheticMetricFilterGetArgs>? Filter { get; set; }

        /// <summary>
        /// The type of the synthetic metric. Possible values: [ ApplicationCache, Callback, CumulativeLayoutShift, DNSLookup, DOMComplete, DOMContentLoaded, DOMInteractive, FailedRequestsResources, FirstContentfulPaint, FirstInputDelay, FirstInputStart, FirstPaint, HTMLDownloaded, HttpErrors, JavaScriptErrors, LargestContentfulPaint, LoadEventEnd, LoadEventStart, LongTasks, NavigationStart, OnDOMContentLoaded, OnLoad, Processing, RedirectTime, Request, RequestStart, ResourceCount, Response, SecureConnect, SpeedIndex, TCPConnect, TimeToFirstByte, TotalDuration, TransferSize, UserActionDuration, VisuallyComplete ]
        /// </summary>
        [Input("metric")]
        public Input<string>? Metric { get; set; }

        /// <summary>
        /// The unique key of the calculated synthetic metric.
        /// </summary>
        [Input("metricKey")]
        public Input<string>? MetricKey { get; set; }

        /// <summary>
        /// The Dynatrace entity ID of the monitor to which the metric belongs.
        /// </summary>
        [Input("monitorIdentifier")]
        public Input<string>? MonitorIdentifier { get; set; }

        /// <summary>
        /// The displayed name of the metric.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public CalculatedSyntheticMetricState()
        {
        }
        public static new CalculatedSyntheticMetricState Empty => new CalculatedSyntheticMetricState();
    }
}
