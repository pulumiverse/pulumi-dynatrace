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
    [DynatraceResourceType("dynatrace:index/serviceNamingOrder:ServiceNamingOrder")]
    public partial class ServiceNamingOrder : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The IDs of the naming rules to define the order for
        /// </summary>
        [Output("namingRuleIds")]
        public Output<ImmutableArray<string>> NamingRuleIds { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceNamingOrder resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceNamingOrder(string name, ServiceNamingOrderArgs? args = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceNamingOrder:ServiceNamingOrder", name, args ?? new ServiceNamingOrderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceNamingOrder(string name, Input<string> id, ServiceNamingOrderState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceNamingOrder:ServiceNamingOrder", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceNamingOrder resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceNamingOrder Get(string name, Input<string> id, ServiceNamingOrderState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceNamingOrder(name, id, state, options);
        }
    }

    public sealed class ServiceNamingOrderArgs : global::Pulumi.ResourceArgs
    {
        [Input("namingRuleIds")]
        private InputList<string>? _namingRuleIds;

        /// <summary>
        /// The IDs of the naming rules to define the order for
        /// </summary>
        public InputList<string> NamingRuleIds
        {
            get => _namingRuleIds ?? (_namingRuleIds = new InputList<string>());
            set => _namingRuleIds = value;
        }

        public ServiceNamingOrderArgs()
        {
        }
        public static new ServiceNamingOrderArgs Empty => new ServiceNamingOrderArgs();
    }

    public sealed class ServiceNamingOrderState : global::Pulumi.ResourceArgs
    {
        [Input("namingRuleIds")]
        private InputList<string>? _namingRuleIds;

        /// <summary>
        /// The IDs of the naming rules to define the order for
        /// </summary>
        public InputList<string> NamingRuleIds
        {
            get => _namingRuleIds ?? (_namingRuleIds = new InputList<string>());
            set => _namingRuleIds = value;
        }

        public ServiceNamingOrderState()
        {
        }
        public static new ServiceNamingOrderState Empty => new ServiceNamingOrderState();
    }
}
