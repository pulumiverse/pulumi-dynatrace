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
    public static class GetManagementZones
    {
        /// <summary>
        /// The management zones data source allows retrieval of all management zones.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetManagementZones.Invoke();
        /// 
        ///     var _name_ = new Dynatrace.CalculatedServiceMetric("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         ManagementZones = new[]
        ///         {
        ///             test.Apply(getManagementZonesResult =&gt; getManagementZonesResult.Values[0]?.Id),
        ///         },
        ///         MetricKey = "calc:service.#name#",
        ///         Unit = "MILLI_SECOND_PER_MINUTE",
        ///         Conditions = new[]
        ///         {
        ///             new Dynatrace.Inputs.CalculatedServiceMetricConditionArgs
        ///             {
        ///                 Conditions = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionArgs
        ///                     {
        ///                         Attribute = "HTTP_REQUEST_METHOD",
        ///                         Comparison = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonArgs
        ///                         {
        ///                             Negate = false,
        ///                             HttpMethod = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs
        ///                             {
        ///                                 Operator = "EQUALS_ANY_OF",
        ///                                 Values = new[]
        ///                                 {
        ///                                     "POST",
        ///                                     "GET",
        ///                                 },
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         MetricDefinition = new Dynatrace.Inputs.CalculatedServiceMetricMetricDefinitionArgs
        ///         {
        ///             Metric = "REQUEST_ATTRIBUTE",
        ///             RequestAttribute = "foo",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetManagementZonesResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetManagementZonesResult>("dynatrace:index/getManagementZones:getManagementZones", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// The management zones data source allows retrieval of all management zones.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetManagementZones.Invoke();
        /// 
        ///     var _name_ = new Dynatrace.CalculatedServiceMetric("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         ManagementZones = new[]
        ///         {
        ///             test.Apply(getManagementZonesResult =&gt; getManagementZonesResult.Values[0]?.Id),
        ///         },
        ///         MetricKey = "calc:service.#name#",
        ///         Unit = "MILLI_SECOND_PER_MINUTE",
        ///         Conditions = new[]
        ///         {
        ///             new Dynatrace.Inputs.CalculatedServiceMetricConditionArgs
        ///             {
        ///                 Conditions = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionArgs
        ///                     {
        ///                         Attribute = "HTTP_REQUEST_METHOD",
        ///                         Comparison = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonArgs
        ///                         {
        ///                             Negate = false,
        ///                             HttpMethod = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs
        ///                             {
        ///                                 Operator = "EQUALS_ANY_OF",
        ///                                 Values = new[]
        ///                                 {
        ///                                     "POST",
        ///                                     "GET",
        ///                                 },
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         MetricDefinition = new Dynatrace.Inputs.CalculatedServiceMetricMetricDefinitionArgs
        ///         {
        ///             Metric = "REQUEST_ATTRIBUTE",
        ///             RequestAttribute = "foo",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetManagementZonesResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetManagementZonesResult>("dynatrace:index/getManagementZones:getManagementZones", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// The management zones data source allows retrieval of all management zones.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetManagementZones.Invoke();
        /// 
        ///     var _name_ = new Dynatrace.CalculatedServiceMetric("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         ManagementZones = new[]
        ///         {
        ///             test.Apply(getManagementZonesResult =&gt; getManagementZonesResult.Values[0]?.Id),
        ///         },
        ///         MetricKey = "calc:service.#name#",
        ///         Unit = "MILLI_SECOND_PER_MINUTE",
        ///         Conditions = new[]
        ///         {
        ///             new Dynatrace.Inputs.CalculatedServiceMetricConditionArgs
        ///             {
        ///                 Conditions = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionArgs
        ///                     {
        ///                         Attribute = "HTTP_REQUEST_METHOD",
        ///                         Comparison = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonArgs
        ///                         {
        ///                             Negate = false,
        ///                             HttpMethod = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs
        ///                             {
        ///                                 Operator = "EQUALS_ANY_OF",
        ///                                 Values = new[]
        ///                                 {
        ///                                     "POST",
        ///                                     "GET",
        ///                                 },
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         MetricDefinition = new Dynatrace.Inputs.CalculatedServiceMetricMetricDefinitionArgs
        ///         {
        ///             Metric = "REQUEST_ATTRIBUTE",
        ///             RequestAttribute = "foo",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetManagementZonesResult> Invoke(InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetManagementZonesResult>("dynatrace:index/getManagementZones:getManagementZones", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetManagementZonesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetManagementZonesValueResult> Values;

        [OutputConstructor]
        private GetManagementZonesResult(
            string id,

            ImmutableArray<Outputs.GetManagementZonesValueResult> values)
        {
            Id = id;
            Values = values;
        }
    }
}
