// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class WebApplicationUserTagsTagArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cleanup rule expression of the userTag
        /// </summary>
        [Input("cleanupRule")]
        public Input<string>? CleanupRule { get; set; }

        [Input("id")]
        public Input<int>? Id { get; set; }

        /// <summary>
        /// If `true`, the value of this tag will always be stored in lower case. Defaults to `false`.
        /// </summary>
        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        /// <summary>
        /// If it's of type metaData, metaData id of the userTag
        /// </summary>
        [Input("metadataId")]
        public Input<int>? MetadataId { get; set; }

        /// <summary>
        /// The ID of the RrequestAttribute for the userTag
        /// </summary>
        [Input("serverSideRequestAttribute")]
        public Input<string>? ServerSideRequestAttribute { get; set; }

        /// <summary>
        /// A unique ID among all userTags and properties of this application. Minimum value is 1.
        /// </summary>
        [Input("uniqueId")]
        public Input<int>? UniqueId { get; set; }

        public WebApplicationUserTagsTagArgs()
        {
        }
        public static new WebApplicationUserTagsTagArgs Empty => new WebApplicationUserTagsTagArgs();
    }
}
