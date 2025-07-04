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
    [DynatraceResourceType("dynatrace:index/attackRules:AttackRules")]
    public partial class AttackRules : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Step 1: Select attack protection behavior
        /// </summary>
        [Output("attackHandling")]
        public Output<Outputs.AttackRulesAttackHandling> AttackHandling { get; private set; } = null!;

        /// <summary>
        /// Step 2: Select attack type
        /// </summary>
        [Output("criteria")]
        public Output<Outputs.AttackRulesCriteria> Criteria { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Step 4: Leave comment (optional)
        /// </summary>
        [Output("metadata")]
        public Output<Outputs.AttackRulesMetadata> Metadata { get; private set; } = null!;

        /// <summary>
        /// If you add more than one condition, note that all conditions must be true simultaneously for the rule to apply.
        /// </summary>
        [Output("resourceAttributeConditions")]
        public Output<Outputs.AttackRulesResourceAttributeConditions?> ResourceAttributeConditions { get; private set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Output("ruleName")]
        public Output<string?> RuleName { get; private set; } = null!;


        /// <summary>
        /// Create a AttackRules resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AttackRules(string name, AttackRulesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/attackRules:AttackRules", name, args ?? new AttackRulesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AttackRules(string name, Input<string> id, AttackRulesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/attackRules:AttackRules", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AttackRules resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AttackRules Get(string name, Input<string> id, AttackRulesState? state = null, CustomResourceOptions? options = null)
        {
            return new AttackRules(name, id, state, options);
        }
    }

    public sealed class AttackRulesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Step 1: Select attack protection behavior
        /// </summary>
        [Input("attackHandling", required: true)]
        public Input<Inputs.AttackRulesAttackHandlingArgs> AttackHandling { get; set; } = null!;

        /// <summary>
        /// Step 2: Select attack type
        /// </summary>
        [Input("criteria", required: true)]
        public Input<Inputs.AttackRulesCriteriaArgs> Criteria { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Step 4: Leave comment (optional)
        /// </summary>
        [Input("metadata", required: true)]
        public Input<Inputs.AttackRulesMetadataArgs> Metadata { get; set; } = null!;

        /// <summary>
        /// If you add more than one condition, note that all conditions must be true simultaneously for the rule to apply.
        /// </summary>
        [Input("resourceAttributeConditions")]
        public Input<Inputs.AttackRulesResourceAttributeConditionsArgs>? ResourceAttributeConditions { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        public AttackRulesArgs()
        {
        }
        public static new AttackRulesArgs Empty => new AttackRulesArgs();
    }

    public sealed class AttackRulesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Step 1: Select attack protection behavior
        /// </summary>
        [Input("attackHandling")]
        public Input<Inputs.AttackRulesAttackHandlingGetArgs>? AttackHandling { get; set; }

        /// <summary>
        /// Step 2: Select attack type
        /// </summary>
        [Input("criteria")]
        public Input<Inputs.AttackRulesCriteriaGetArgs>? Criteria { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Step 4: Leave comment (optional)
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.AttackRulesMetadataGetArgs>? Metadata { get; set; }

        /// <summary>
        /// If you add more than one condition, note that all conditions must be true simultaneously for the rule to apply.
        /// </summary>
        [Input("resourceAttributeConditions")]
        public Input<Inputs.AttackRulesResourceAttributeConditionsGetArgs>? ResourceAttributeConditions { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        public AttackRulesState()
        {
        }
        public static new AttackRulesState Empty => new AttackRulesState();
    }
}
