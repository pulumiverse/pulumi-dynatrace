// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/requestAttribute:RequestAttribute")]
    public partial class RequestAttribute : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Aggregation type for the request values
        /// </summary>
        [Output("aggregation")]
        public Output<string> Aggregation { get; private set; } = null!;

        /// <summary>
        /// Confidential data flag. Set `true` to treat the captured data as confidential
        /// </summary>
        [Output("confidential")]
        public Output<bool?> Confidential { get; private set; } = null!;

        /// <summary>
        /// The list of data sources
        /// </summary>
        [Output("dataSources")]
        public Output<ImmutableArray<Outputs.RequestAttributeDataSource>> DataSources { get; private set; } = null!;

        /// <summary>
        /// The data type of the request attribute
        /// </summary>
        [Output("dataType")]
        public Output<string> DataType { get; private set; } = null!;

        /// <summary>
        /// The request attribute is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The name of the request attribute
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// String values transformation.   If the **dataType** is not `string`, set the `Original` here
        /// </summary>
        [Output("normalization")]
        public Output<string> Normalization { get; private set; } = null!;

        /// <summary>
        /// Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        /// </summary>
        [Output("skipPersonalDataMasking")]
        public Output<bool?> SkipPersonalDataMasking { get; private set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Output("unknowns")]
        public Output<string?> Unknowns { get; private set; } = null!;


        /// <summary>
        /// Create a RequestAttribute resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RequestAttribute(string name, RequestAttributeArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/requestAttribute:RequestAttribute", name, args ?? new RequestAttributeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RequestAttribute(string name, Input<string> id, RequestAttributeState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/requestAttribute:RequestAttribute", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RequestAttribute resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RequestAttribute Get(string name, Input<string> id, RequestAttributeState? state = null, CustomResourceOptions? options = null)
        {
            return new RequestAttribute(name, id, state, options);
        }
    }

    public sealed class RequestAttributeArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Aggregation type for the request values
        /// </summary>
        [Input("aggregation", required: true)]
        public Input<string> Aggregation { get; set; } = null!;

        /// <summary>
        /// Confidential data flag. Set `true` to treat the captured data as confidential
        /// </summary>
        [Input("confidential")]
        public Input<bool>? Confidential { get; set; }

        [Input("dataSources")]
        private InputList<Inputs.RequestAttributeDataSourceArgs>? _dataSources;

        /// <summary>
        /// The list of data sources
        /// </summary>
        public InputList<Inputs.RequestAttributeDataSourceArgs> DataSources
        {
            get => _dataSources ?? (_dataSources = new InputList<Inputs.RequestAttributeDataSourceArgs>());
            set => _dataSources = value;
        }

        /// <summary>
        /// The data type of the request attribute
        /// </summary>
        [Input("dataType", required: true)]
        public Input<string> DataType { get; set; } = null!;

        /// <summary>
        /// The request attribute is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the request attribute
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// String values transformation.   If the **dataType** is not `string`, set the `Original` here
        /// </summary>
        [Input("normalization", required: true)]
        public Input<string> Normalization { get; set; } = null!;

        /// <summary>
        /// Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        /// </summary>
        [Input("skipPersonalDataMasking")]
        public Input<bool>? SkipPersonalDataMasking { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public RequestAttributeArgs()
        {
        }
        public static new RequestAttributeArgs Empty => new RequestAttributeArgs();
    }

    public sealed class RequestAttributeState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Aggregation type for the request values
        /// </summary>
        [Input("aggregation")]
        public Input<string>? Aggregation { get; set; }

        /// <summary>
        /// Confidential data flag. Set `true` to treat the captured data as confidential
        /// </summary>
        [Input("confidential")]
        public Input<bool>? Confidential { get; set; }

        [Input("dataSources")]
        private InputList<Inputs.RequestAttributeDataSourceGetArgs>? _dataSources;

        /// <summary>
        /// The list of data sources
        /// </summary>
        public InputList<Inputs.RequestAttributeDataSourceGetArgs> DataSources
        {
            get => _dataSources ?? (_dataSources = new InputList<Inputs.RequestAttributeDataSourceGetArgs>());
            set => _dataSources = value;
        }

        /// <summary>
        /// The data type of the request attribute
        /// </summary>
        [Input("dataType")]
        public Input<string>? DataType { get; set; }

        /// <summary>
        /// The request attribute is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the request attribute
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// String values transformation.   If the **dataType** is not `string`, set the `Original` here
        /// </summary>
        [Input("normalization")]
        public Input<string>? Normalization { get; set; }

        /// <summary>
        /// Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        /// </summary>
        [Input("skipPersonalDataMasking")]
        public Input<bool>? SkipPersonalDataMasking { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public RequestAttributeState()
        {
        }
        public static new RequestAttributeState Empty => new RequestAttributeState();
    }
}