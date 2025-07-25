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
    public static class GetPlatformSloTemplate
    {
        /// <summary>
        /// &gt; To utilize this data source, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **View SLOs** (`slo:slos:read`) and **View SLO objective templates** (`slo:objective-templates:read`).
        /// 
        /// The SLO objective template data source allows the ID to be retrieved by its name.
        /// 
        /// - `name` (String) Name of the SLO objective template
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var hostCPU = Dynatrace.GetPlatformSloTemplate.Invoke(new()
        ///     {
        ///         Name = "Host CPU usage utilization",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.PlatformSlo("#name#", new()
        ///     {
        ///         Description = "Measures the CPU usage of selected hosts over time.",
        ///         Criteria = new Dynatrace.Inputs.PlatformSloCriteriaArgs
        ///         {
        ///             CriteriaDetails = new[]
        ///             {
        ///                 new Dynatrace.Inputs.PlatformSloCriteriaCriteriaDetailArgs
        ///                 {
        ///                     Target = 95,
        ///                     TimeframeFrom = "now-7d",
        ///                     TimeframeTo = "now",
        ///                 },
        ///             },
        ///         },
        ///         SliReference = new Dynatrace.Inputs.PlatformSloSliReferenceArgs
        ///         {
        ///             TemplateId = hostCPU.Apply(getPlatformSloTemplateResult =&gt; getPlatformSloTemplateResult.Id),
        ///             Variables = new Dynatrace.Inputs.PlatformSloSliReferenceVariablesArgs
        ///             {
        ///                 SliReferenceVariables = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs
        ///                     {
        ///                         Name = "hosts",
        ///                         Value = "\"HOST-1234567890000000\"",
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetPlatformSloTemplateResult> InvokeAsync(GetPlatformSloTemplateArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetPlatformSloTemplateResult>("dynatrace:index/getPlatformSloTemplate:getPlatformSloTemplate", args ?? new GetPlatformSloTemplateArgs(), options.WithDefaults());

        /// <summary>
        /// &gt; To utilize this data source, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **View SLOs** (`slo:slos:read`) and **View SLO objective templates** (`slo:objective-templates:read`).
        /// 
        /// The SLO objective template data source allows the ID to be retrieved by its name.
        /// 
        /// - `name` (String) Name of the SLO objective template
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var hostCPU = Dynatrace.GetPlatformSloTemplate.Invoke(new()
        ///     {
        ///         Name = "Host CPU usage utilization",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.PlatformSlo("#name#", new()
        ///     {
        ///         Description = "Measures the CPU usage of selected hosts over time.",
        ///         Criteria = new Dynatrace.Inputs.PlatformSloCriteriaArgs
        ///         {
        ///             CriteriaDetails = new[]
        ///             {
        ///                 new Dynatrace.Inputs.PlatformSloCriteriaCriteriaDetailArgs
        ///                 {
        ///                     Target = 95,
        ///                     TimeframeFrom = "now-7d",
        ///                     TimeframeTo = "now",
        ///                 },
        ///             },
        ///         },
        ///         SliReference = new Dynatrace.Inputs.PlatformSloSliReferenceArgs
        ///         {
        ///             TemplateId = hostCPU.Apply(getPlatformSloTemplateResult =&gt; getPlatformSloTemplateResult.Id),
        ///             Variables = new Dynatrace.Inputs.PlatformSloSliReferenceVariablesArgs
        ///             {
        ///                 SliReferenceVariables = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs
        ///                     {
        ///                         Name = "hosts",
        ///                         Value = "\"HOST-1234567890000000\"",
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetPlatformSloTemplateResult> Invoke(GetPlatformSloTemplateInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetPlatformSloTemplateResult>("dynatrace:index/getPlatformSloTemplate:getPlatformSloTemplate", args ?? new GetPlatformSloTemplateInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// &gt; To utilize this data source, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **View SLOs** (`slo:slos:read`) and **View SLO objective templates** (`slo:objective-templates:read`).
        /// 
        /// The SLO objective template data source allows the ID to be retrieved by its name.
        /// 
        /// - `name` (String) Name of the SLO objective template
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var hostCPU = Dynatrace.GetPlatformSloTemplate.Invoke(new()
        ///     {
        ///         Name = "Host CPU usage utilization",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.PlatformSlo("#name#", new()
        ///     {
        ///         Description = "Measures the CPU usage of selected hosts over time.",
        ///         Criteria = new Dynatrace.Inputs.PlatformSloCriteriaArgs
        ///         {
        ///             CriteriaDetails = new[]
        ///             {
        ///                 new Dynatrace.Inputs.PlatformSloCriteriaCriteriaDetailArgs
        ///                 {
        ///                     Target = 95,
        ///                     TimeframeFrom = "now-7d",
        ///                     TimeframeTo = "now",
        ///                 },
        ///             },
        ///         },
        ///         SliReference = new Dynatrace.Inputs.PlatformSloSliReferenceArgs
        ///         {
        ///             TemplateId = hostCPU.Apply(getPlatformSloTemplateResult =&gt; getPlatformSloTemplateResult.Id),
        ///             Variables = new Dynatrace.Inputs.PlatformSloSliReferenceVariablesArgs
        ///             {
        ///                 SliReferenceVariables = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs
        ///                     {
        ///                         Name = "hosts",
        ///                         Value = "\"HOST-1234567890000000\"",
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetPlatformSloTemplateResult> Invoke(GetPlatformSloTemplateInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetPlatformSloTemplateResult>("dynatrace:index/getPlatformSloTemplate:getPlatformSloTemplate", args ?? new GetPlatformSloTemplateInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPlatformSloTemplateArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the SLO objective template
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetPlatformSloTemplateArgs()
        {
        }
        public static new GetPlatformSloTemplateArgs Empty => new GetPlatformSloTemplateArgs();
    }

    public sealed class GetPlatformSloTemplateInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the SLO objective template
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetPlatformSloTemplateInvokeArgs()
        {
        }
        public static new GetPlatformSloTemplateInvokeArgs Empty => new GetPlatformSloTemplateInvokeArgs();
    }


    [OutputType]
    public sealed class GetPlatformSloTemplateResult
    {
        /// <summary>
        /// ID of the SLO objective template
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the SLO objective template
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetPlatformSloTemplateResult(
            string id,

            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
