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
    public static class GetEntities
    {
        /// <summary>
        /// The entities data source allows all entities to be retrieved by its type.
        /// 
        /// - `type` (String) Type of the entity, e.g. SERVICE. All available entity types can be retrieved with [/api/v2/entityTypes](https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2/get-all-entity-types).
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetEntities.Invoke(new()
        ///     {
        ///         Type = "SERVICE",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["serviceList"] = test.Apply(getEntitiesResult =&gt; getEntitiesResult.Entities),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetEntitiesResult> InvokeAsync(GetEntitiesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEntitiesResult>("dynatrace:index/getEntities:getEntities", args ?? new GetEntitiesArgs(), options.WithDefaults());

        /// <summary>
        /// The entities data source allows all entities to be retrieved by its type.
        /// 
        /// - `type` (String) Type of the entity, e.g. SERVICE. All available entity types can be retrieved with [/api/v2/entityTypes](https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2/get-all-entity-types).
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetEntities.Invoke(new()
        ///     {
        ///         Type = "SERVICE",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["serviceList"] = test.Apply(getEntitiesResult =&gt; getEntitiesResult.Entities),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetEntitiesResult> Invoke(GetEntitiesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEntitiesResult>("dynatrace:index/getEntities:getEntities", args ?? new GetEntitiesInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The entities data source allows all entities to be retrieved by its type.
        /// 
        /// - `type` (String) Type of the entity, e.g. SERVICE. All available entity types can be retrieved with [/api/v2/entityTypes](https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2/get-all-entity-types).
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetEntities.Invoke(new()
        ///     {
        ///         Type = "SERVICE",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["serviceList"] = test.Apply(getEntitiesResult =&gt; getEntitiesResult.Entities),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetEntitiesResult> Invoke(GetEntitiesInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetEntitiesResult>("dynatrace:index/getEntities:getEntities", args ?? new GetEntitiesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEntitiesArgs : global::Pulumi.InvokeArgs
    {
        [Input("entitySelector")]
        public string? EntitySelector { get; set; }

        [Input("from")]
        public string? From { get; set; }

        [Input("to")]
        public string? To { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        public GetEntitiesArgs()
        {
        }
        public static new GetEntitiesArgs Empty => new GetEntitiesArgs();
    }

    public sealed class GetEntitiesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("entitySelector")]
        public Input<string>? EntitySelector { get; set; }

        [Input("from")]
        public Input<string>? From { get; set; }

        [Input("to")]
        public Input<string>? To { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetEntitiesInvokeArgs()
        {
        }
        public static new GetEntitiesInvokeArgs Empty => new GetEntitiesInvokeArgs();
    }


    [OutputType]
    public sealed class GetEntitiesResult
    {
        public readonly ImmutableArray<Outputs.GetEntitiesEntityResult> Entities;
        public readonly string? EntitySelector;
        public readonly string? From;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? To;
        public readonly string? Type;

        [OutputConstructor]
        private GetEntitiesResult(
            ImmutableArray<Outputs.GetEntitiesEntityResult> entities,

            string? entitySelector,

            string? from,

            string id,

            string? to,

            string? type)
        {
            Entities = entities;
            EntitySelector = entitySelector;
            From = from;
            Id = id;
            To = to;
            Type = type;
        }
    }
}
