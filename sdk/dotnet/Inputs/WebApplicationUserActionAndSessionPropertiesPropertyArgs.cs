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

    public sealed class WebApplicationUserActionAndSessionPropertiesPropertyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The aggregation type of the property.
        /// </summary>
        [Input("aggregation")]
        public Input<string>? Aggregation { get; set; }

        /// <summary>
        /// The cleanup rule of the property. 
        /// 
        /// Defines how to extract the data you need from a string value. Specify the [regular expression](https://dt-url.net/k9e0iaq) for the data you need there
        /// </summary>
        [Input("cleanupRule")]
        public Input<string>? CleanupRule { get; set; }

        /// <summary>
        /// The display name of the property
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Unique id among all userTags and properties of this application
        /// </summary>
        [Input("id", required: true)]
        public Input<int> Id { get; set; } = null!;

        /// <summary>
        /// If `true`, the value of this property will always be stored in lower case. Defaults to `false`.
        /// </summary>
        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        /// <summary>
        /// Key of the property
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// If the `type` is `LONG_STRING`, the max length for this property. Must be a multiple of `100`. Defaults to `200`. Maximum is `1000`.
        /// </summary>
        [Input("longStringLength")]
        public Input<int>? LongStringLength { get; set; }

        /// <summary>
        /// If the origin is `META_DATA`, metaData id of the property
        /// </summary>
        [Input("metadataId")]
        public Input<int>? MetadataId { get; set; }

        /// <summary>
        /// The origin of the property. Possible values are `JAVASCRIPT_API`, `META_DATA` and `SERVER_SIDE_REQUEST_ATTRIBUTE`.
        /// </summary>
        [Input("origin", required: true)]
        public Input<string> Origin { get; set; } = null!;

        /// <summary>
        /// The ID of the request attribute. 
        /// 
        /// Only applicable when the **origin** is set to `SERVER_SIDE_REQUEST_ATTRIBUTE`
        /// </summary>
        [Input("serverSideRequestAttribute")]
        public Input<string>? ServerSideRequestAttribute { get; set; }

        /// <summary>
        /// If `true`, the property is stored as a session property
        /// </summary>
        [Input("storeAsSessionProperty")]
        public Input<bool>? StoreAsSessionProperty { get; set; }

        /// <summary>
        /// If `true`, the property is stored as a user action property
        /// </summary>
        [Input("storeAsUserActionProperty")]
        public Input<bool>? StoreAsUserActionProperty { get; set; }

        /// <summary>
        /// The data type of the property. Possible values are `DATE`, `DOUBLE`, `LONG`, `LONG_STRING` and `STRING`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public WebApplicationUserActionAndSessionPropertiesPropertyArgs()
        {
        }
        public static new WebApplicationUserActionAndSessionPropertiesPropertyArgs Empty => new WebApplicationUserActionAndSessionPropertiesPropertyArgs();
    }
}