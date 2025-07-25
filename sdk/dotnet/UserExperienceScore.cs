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
    [DynatraceResourceType("dynatrace:index/userExperienceScore:UserExperienceScore")]
    public partial class UserExperienceScore : global::Pulumi.CustomResource
    {
        /// <summary>
        /// If last user action in a session is classified as Frustrating, classify the entire session as Frustrating
        /// </summary>
        [Output("considerLastAction")]
        public Output<bool> ConsiderLastAction { get; private set; } = null!;

        /// <summary>
        /// Consider rage clicks / rage taps in score calculation
        /// </summary>
        [Output("considerRageClick")]
        public Output<bool> ConsiderRageClick { get; private set; } = null!;

        /// <summary>
        /// User experience is considered Frustrating when the selected percentage or more of the user actions in a session are rated as Frustrating.
        /// </summary>
        [Output("maxFrustratedUserActionsThreshold")]
        public Output<int> MaxFrustratedUserActionsThreshold { get; private set; } = null!;

        /// <summary>
        /// User experience is considered Satisfying when at least the selected percentage of the user actions in a session are rated as Satisfying.
        /// </summary>
        [Output("minSatisfiedUserActionsThreshold")]
        public Output<int> MinSatisfiedUserActionsThreshold { get; private set; } = null!;


        /// <summary>
        /// Create a UserExperienceScore resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserExperienceScore(string name, UserExperienceScoreArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/userExperienceScore:UserExperienceScore", name, args ?? new UserExperienceScoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserExperienceScore(string name, Input<string> id, UserExperienceScoreState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/userExperienceScore:UserExperienceScore", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UserExperienceScore resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserExperienceScore Get(string name, Input<string> id, UserExperienceScoreState? state = null, CustomResourceOptions? options = null)
        {
            return new UserExperienceScore(name, id, state, options);
        }
    }

    public sealed class UserExperienceScoreArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If last user action in a session is classified as Frustrating, classify the entire session as Frustrating
        /// </summary>
        [Input("considerLastAction", required: true)]
        public Input<bool> ConsiderLastAction { get; set; } = null!;

        /// <summary>
        /// Consider rage clicks / rage taps in score calculation
        /// </summary>
        [Input("considerRageClick", required: true)]
        public Input<bool> ConsiderRageClick { get; set; } = null!;

        /// <summary>
        /// User experience is considered Frustrating when the selected percentage or more of the user actions in a session are rated as Frustrating.
        /// </summary>
        [Input("maxFrustratedUserActionsThreshold", required: true)]
        public Input<int> MaxFrustratedUserActionsThreshold { get; set; } = null!;

        /// <summary>
        /// User experience is considered Satisfying when at least the selected percentage of the user actions in a session are rated as Satisfying.
        /// </summary>
        [Input("minSatisfiedUserActionsThreshold", required: true)]
        public Input<int> MinSatisfiedUserActionsThreshold { get; set; } = null!;

        public UserExperienceScoreArgs()
        {
        }
        public static new UserExperienceScoreArgs Empty => new UserExperienceScoreArgs();
    }

    public sealed class UserExperienceScoreState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If last user action in a session is classified as Frustrating, classify the entire session as Frustrating
        /// </summary>
        [Input("considerLastAction")]
        public Input<bool>? ConsiderLastAction { get; set; }

        /// <summary>
        /// Consider rage clicks / rage taps in score calculation
        /// </summary>
        [Input("considerRageClick")]
        public Input<bool>? ConsiderRageClick { get; set; }

        /// <summary>
        /// User experience is considered Frustrating when the selected percentage or more of the user actions in a session are rated as Frustrating.
        /// </summary>
        [Input("maxFrustratedUserActionsThreshold")]
        public Input<int>? MaxFrustratedUserActionsThreshold { get; set; }

        /// <summary>
        /// User experience is considered Satisfying when at least the selected percentage of the user actions in a session are rated as Satisfying.
        /// </summary>
        [Input("minSatisfiedUserActionsThreshold")]
        public Input<int>? MinSatisfiedUserActionsThreshold { get; set; }

        public UserExperienceScoreState()
        {
        }
        public static new UserExperienceScoreState Empty => new UserExperienceScoreState();
    }
}
