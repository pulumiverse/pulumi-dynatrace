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
    public static class GetApiTokens
    {
        /// <summary>
        /// The API tokens data source allows all access tokens to be retrieved, note the token value is not included in the response.
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
        ///     var exampleApiTokens = Dynatrace.GetApiTokens.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["example"] = exampleApiTokens,
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetApiTokensResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiTokensResult>("dynatrace:index/getApiTokens:getApiTokens", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// The API tokens data source allows all access tokens to be retrieved, note the token value is not included in the response.
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
        ///     var exampleApiTokens = Dynatrace.GetApiTokens.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["example"] = exampleApiTokens,
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetApiTokensResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiTokensResult>("dynatrace:index/getApiTokens:getApiTokens", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetApiTokensResult
    {
        public readonly ImmutableArray<Outputs.GetApiTokensApiTokenResult> ApiTokens;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetApiTokensResult(
            ImmutableArray<Outputs.GetApiTokensApiTokenResult> apiTokens,

            string id)
        {
            ApiTokens = apiTokens;
            Id = id;
        }
    }
}