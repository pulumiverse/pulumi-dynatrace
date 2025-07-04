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
    public static class GetDashboard
    {
        /// <summary>
        /// The `dynatrace.Dashboard` data source allows the dashboard ID to be retrieved by its name and owner.
        /// 
        /// - `name` (String) - The name of the dashboard
        /// - `owner` (String) - The owner of the dashboard
        /// 
        /// If multiple services match the given criteria, the first result will be retrieved.
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
        ///     var example = Dynatrace.GetDashboard.Invoke(new()
        ///     {
        ///         Name = "Terraform",
        ///         Owner = "Hashicorp",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getDashboardResult =&gt; getDashboardResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetDashboardResult> InvokeAsync(GetDashboardArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDashboardResult>("dynatrace:index/getDashboard:getDashboard", args ?? new GetDashboardArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.Dashboard` data source allows the dashboard ID to be retrieved by its name and owner.
        /// 
        /// - `name` (String) - The name of the dashboard
        /// - `owner` (String) - The owner of the dashboard
        /// 
        /// If multiple services match the given criteria, the first result will be retrieved.
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
        ///     var example = Dynatrace.GetDashboard.Invoke(new()
        ///     {
        ///         Name = "Terraform",
        ///         Owner = "Hashicorp",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getDashboardResult =&gt; getDashboardResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetDashboardResult> Invoke(GetDashboardInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDashboardResult>("dynatrace:index/getDashboard:getDashboard", args ?? new GetDashboardInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.Dashboard` data source allows the dashboard ID to be retrieved by its name and owner.
        /// 
        /// - `name` (String) - The name of the dashboard
        /// - `owner` (String) - The owner of the dashboard
        /// 
        /// If multiple services match the given criteria, the first result will be retrieved.
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
        ///     var example = Dynatrace.GetDashboard.Invoke(new()
        ///     {
        ///         Name = "Terraform",
        ///         Owner = "Hashicorp",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["id"] = example.Apply(getDashboardResult =&gt; getDashboardResult.Id),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetDashboardResult> Invoke(GetDashboardInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetDashboardResult>("dynatrace:index/getDashboard:getDashboard", args ?? new GetDashboardInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDashboardArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("owner", required: true)]
        public string Owner { get; set; } = null!;

        public GetDashboardArgs()
        {
        }
        public static new GetDashboardArgs Empty => new GetDashboardArgs();
    }

    public sealed class GetDashboardInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        public GetDashboardInvokeArgs()
        {
        }
        public static new GetDashboardInvokeArgs Empty => new GetDashboardInvokeArgs();
    }


    [OutputType]
    public sealed class GetDashboardResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string Owner;

        [OutputConstructor]
        private GetDashboardResult(
            string id,

            string name,

            string owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
        }
    }
}
