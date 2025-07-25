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
    public static class GetUpdateWindows
    {
        /// <summary>
        /// The `dynatrace.UpdateWindows` data source allows the OneAgent update maintenance window ID to be retrieved by its name.
        /// 
        /// - `name` (String) - The name of the OneAgent update maintenance window
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
        ///     var example = Dynatrace.GetUpdateWindows.Invoke(new()
        ///     {
        ///         Name = "Terraform Example",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getUpdateWindowsResult =&gt; getUpdateWindowsResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetUpdateWindowsResult> InvokeAsync(GetUpdateWindowsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUpdateWindowsResult>("dynatrace:index/getUpdateWindows:getUpdateWindows", args ?? new GetUpdateWindowsArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.UpdateWindows` data source allows the OneAgent update maintenance window ID to be retrieved by its name.
        /// 
        /// - `name` (String) - The name of the OneAgent update maintenance window
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
        ///     var example = Dynatrace.GetUpdateWindows.Invoke(new()
        ///     {
        ///         Name = "Terraform Example",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getUpdateWindowsResult =&gt; getUpdateWindowsResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetUpdateWindowsResult> Invoke(GetUpdateWindowsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUpdateWindowsResult>("dynatrace:index/getUpdateWindows:getUpdateWindows", args ?? new GetUpdateWindowsInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.UpdateWindows` data source allows the OneAgent update maintenance window ID to be retrieved by its name.
        /// 
        /// - `name` (String) - The name of the OneAgent update maintenance window
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
        ///     var example = Dynatrace.GetUpdateWindows.Invoke(new()
        ///     {
        ///         Name = "Terraform Example",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getUpdateWindowsResult =&gt; getUpdateWindowsResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetUpdateWindowsResult> Invoke(GetUpdateWindowsInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetUpdateWindowsResult>("dynatrace:index/getUpdateWindows:getUpdateWindows", args ?? new GetUpdateWindowsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUpdateWindowsArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetUpdateWindowsArgs()
        {
        }
        public static new GetUpdateWindowsArgs Empty => new GetUpdateWindowsArgs();
    }

    public sealed class GetUpdateWindowsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetUpdateWindowsInvokeArgs()
        {
        }
        public static new GetUpdateWindowsInvokeArgs Empty => new GetUpdateWindowsInvokeArgs();
    }


    [OutputType]
    public sealed class GetUpdateWindowsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;

        [OutputConstructor]
        private GetUpdateWindowsResult(
            string id,

            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
