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
    [DynatraceResourceType("dynatrace:index/sloV2:SloV2")]
    public partial class SloV2 : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the SLO
        /// </summary>
        [Output("customDescription")]
        public Output<string?> CustomDescription { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// ### Error budget burn rate
        /// </summary>
        [Output("errorBudgetBurnRate")]
        public Output<Outputs.SloV2ErrorBudgetBurnRate> ErrorBudgetBurnRate { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `AGGREGATE`
        /// </summary>
        [Output("evaluationType")]
        public Output<string> EvaluationType { get; private set; } = null!;

        /// <summary>
        /// Define the timeframe during which the SLO is to be evaluated. For the timeframe you can enter expressions like -1h (last hour), -1w (last week) or complex expressions like -2d to now (last two days), -1d/d to now/d (beginning of yesterday to beginning of today).
        /// </summary>
        [Output("evaluationWindow")]
        public Output<string> EvaluationWindow { get; private set; } = null!;

        /// <summary>
        /// Set a filter parameter (entitySelector) on any GET call to evaluate this SLO against specific services only (for example, type("SERVICE")).  For details, see the [Entity Selector documentation](https://dt-url.net/entityselector).
        /// </summary>
        [Output("filter")]
        public Output<string> Filter { get; private set; } = null!;

        /// <summary>
        /// The ID of this setting when referred to by the Config REST API V1
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

        /// <summary>
        /// For details, see the [Metrics page](https://www.terraform.io/ui/metrics).
        /// </summary>
        [Output("metricExpression")]
        public Output<string> MetricExpression { get; private set; } = null!;

        /// <summary>
        /// Metric name
        /// </summary>
        [Output("metricName")]
        public Output<string> MetricName { get; private set; } = null!;

        /// <summary>
        /// SLO name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Set the target value of the SLO. A percentage below this value indicates a failure.
        /// </summary>
        [Output("targetSuccess")]
        public Output<double> TargetSuccess { get; private set; } = null!;

        /// <summary>
        /// Set the warning value of the SLO. At the warning state the SLO is fulfilled. However, it is getting close to a failure.
        /// </summary>
        [Output("targetWarning")]
        public Output<double> TargetWarning { get; private set; } = null!;


        /// <summary>
        /// Create a SloV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SloV2(string name, SloV2Args args, CustomResourceOptions? options = null)
            : base("dynatrace:index/sloV2:SloV2", name, args ?? new SloV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private SloV2(string name, Input<string> id, SloV2State? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/sloV2:SloV2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SloV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SloV2 Get(string name, Input<string> id, SloV2State? state = null, CustomResourceOptions? options = null)
        {
            return new SloV2(name, id, state, options);
        }
    }

    public sealed class SloV2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the SLO
        /// </summary>
        [Input("customDescription")]
        public Input<string>? CustomDescription { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// ### Error budget burn rate
        /// </summary>
        [Input("errorBudgetBurnRate", required: true)]
        public Input<Inputs.SloV2ErrorBudgetBurnRateArgs> ErrorBudgetBurnRate { get; set; } = null!;

        /// <summary>
        /// Possible Values: `AGGREGATE`
        /// </summary>
        [Input("evaluationType", required: true)]
        public Input<string> EvaluationType { get; set; } = null!;

        /// <summary>
        /// Define the timeframe during which the SLO is to be evaluated. For the timeframe you can enter expressions like -1h (last hour), -1w (last week) or complex expressions like -2d to now (last two days), -1d/d to now/d (beginning of yesterday to beginning of today).
        /// </summary>
        [Input("evaluationWindow", required: true)]
        public Input<string> EvaluationWindow { get; set; } = null!;

        /// <summary>
        /// Set a filter parameter (entitySelector) on any GET call to evaluate this SLO against specific services only (for example, type("SERVICE")).  For details, see the [Entity Selector documentation](https://dt-url.net/entityselector).
        /// </summary>
        [Input("filter", required: true)]
        public Input<string> Filter { get; set; } = null!;

        /// <summary>
        /// The ID of this setting when referred to by the Config REST API V1
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// For details, see the [Metrics page](https://www.terraform.io/ui/metrics).
        /// </summary>
        [Input("metricExpression", required: true)]
        public Input<string> MetricExpression { get; set; } = null!;

        /// <summary>
        /// Metric name
        /// </summary>
        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        /// <summary>
        /// SLO name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Set the target value of the SLO. A percentage below this value indicates a failure.
        /// </summary>
        [Input("targetSuccess", required: true)]
        public Input<double> TargetSuccess { get; set; } = null!;

        /// <summary>
        /// Set the warning value of the SLO. At the warning state the SLO is fulfilled. However, it is getting close to a failure.
        /// </summary>
        [Input("targetWarning", required: true)]
        public Input<double> TargetWarning { get; set; } = null!;

        public SloV2Args()
        {
        }
        public static new SloV2Args Empty => new SloV2Args();
    }

    public sealed class SloV2State : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the SLO
        /// </summary>
        [Input("customDescription")]
        public Input<string>? CustomDescription { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// ### Error budget burn rate
        /// </summary>
        [Input("errorBudgetBurnRate")]
        public Input<Inputs.SloV2ErrorBudgetBurnRateGetArgs>? ErrorBudgetBurnRate { get; set; }

        /// <summary>
        /// Possible Values: `AGGREGATE`
        /// </summary>
        [Input("evaluationType")]
        public Input<string>? EvaluationType { get; set; }

        /// <summary>
        /// Define the timeframe during which the SLO is to be evaluated. For the timeframe you can enter expressions like -1h (last hour), -1w (last week) or complex expressions like -2d to now (last two days), -1d/d to now/d (beginning of yesterday to beginning of today).
        /// </summary>
        [Input("evaluationWindow")]
        public Input<string>? EvaluationWindow { get; set; }

        /// <summary>
        /// Set a filter parameter (entitySelector) on any GET call to evaluate this SLO against specific services only (for example, type("SERVICE")).  For details, see the [Entity Selector documentation](https://dt-url.net/entityselector).
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// The ID of this setting when referred to by the Config REST API V1
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// For details, see the [Metrics page](https://www.terraform.io/ui/metrics).
        /// </summary>
        [Input("metricExpression")]
        public Input<string>? MetricExpression { get; set; }

        /// <summary>
        /// Metric name
        /// </summary>
        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        /// <summary>
        /// SLO name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Set the target value of the SLO. A percentage below this value indicates a failure.
        /// </summary>
        [Input("targetSuccess")]
        public Input<double>? TargetSuccess { get; set; }

        /// <summary>
        /// Set the warning value of the SLO. At the warning state the SLO is fulfilled. However, it is getting close to a failure.
        /// </summary>
        [Input("targetWarning")]
        public Input<double>? TargetWarning { get; set; }

        public SloV2State()
        {
        }
        public static new SloV2State Empty => new SloV2State();
    }
}
