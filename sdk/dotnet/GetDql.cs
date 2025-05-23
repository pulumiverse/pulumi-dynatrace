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
    public static class GetDql
    {
        /// <summary>
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
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = "fetch events",
        ///     });
        /// 
        /// });
        /// ```
        /// will produce content for the `results` attribute like this:
        /// ```
        /// [
        ///     {
        ///         "event.id"                             = "-7629786693326919096_1745910027748"
        ///         "Event source"                         = "OS services monitoring"
        ///         ...
        ///         timestamp                              = "2025-04-29T07:00:44.416000000Z"
        ///     },
        ///     {
        ///         ...
        ///     },
        ///     ...
        /// ]
        /// ```
        /// 
        /// You can also use Heredoc syntax for better readability of complex DQL queries.
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = @"    fetch events |
        ///     filter event.type == ""davis"" AND davis.status != ""CLOSED"" |
        ///     fields timestamp, davis.title, davis.underMaintenance, davis.status |
        ///     sort timestamp |
        ///     limit 10  
        /// 
        /// ",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// {{ .SchemaMarkdown | trimspace }}
        /// </summary>
        public static Task<GetDqlResult> InvokeAsync(GetDqlArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDqlResult>("dynatrace:index/getDql:getDql", args ?? new GetDqlArgs(), options.WithDefaults());

        /// <summary>
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
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = "fetch events",
        ///     });
        /// 
        /// });
        /// ```
        /// will produce content for the `results` attribute like this:
        /// ```
        /// [
        ///     {
        ///         "event.id"                             = "-7629786693326919096_1745910027748"
        ///         "Event source"                         = "OS services monitoring"
        ///         ...
        ///         timestamp                              = "2025-04-29T07:00:44.416000000Z"
        ///     },
        ///     {
        ///         ...
        ///     },
        ///     ...
        /// ]
        /// ```
        /// 
        /// You can also use Heredoc syntax for better readability of complex DQL queries.
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = @"    fetch events |
        ///     filter event.type == ""davis"" AND davis.status != ""CLOSED"" |
        ///     fields timestamp, davis.title, davis.underMaintenance, davis.status |
        ///     sort timestamp |
        ///     limit 10  
        /// 
        /// ",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// {{ .SchemaMarkdown | trimspace }}
        /// </summary>
        public static Output<GetDqlResult> Invoke(GetDqlInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDqlResult>("dynatrace:index/getDql:getDql", args ?? new GetDqlInvokeArgs(), options.WithDefaults());

        /// <summary>
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
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = "fetch events",
        ///     });
        /// 
        /// });
        /// ```
        /// will produce content for the `results` attribute like this:
        /// ```
        /// [
        ///     {
        ///         "event.id"                             = "-7629786693326919096_1745910027748"
        ///         "Event source"                         = "OS services monitoring"
        ///         ...
        ///         timestamp                              = "2025-04-29T07:00:44.416000000Z"
        ///     },
        ///     {
        ///         ...
        ///     },
        ///     ...
        /// ]
        /// ```
        /// 
        /// You can also use Heredoc syntax for better readability of complex DQL queries.
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Dynatrace.GetDql.Invoke(new()
        ///     {
        ///         Query = @"    fetch events |
        ///     filter event.type == ""davis"" AND davis.status != ""CLOSED"" |
        ///     fields timestamp, davis.title, davis.underMaintenance, davis.status |
        ///     sort timestamp |
        ///     limit 10  
        /// 
        /// ",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// {{ .SchemaMarkdown | trimspace }}
        /// </summary>
        public static Output<GetDqlResult> Invoke(GetDqlInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetDqlResult>("dynatrace:index/getDql:getDql", args ?? new GetDqlInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDqlArgs : global::Pulumi.InvokeArgs
    {
        [Input("defaultSamplingRatio")]
        public double? DefaultSamplingRatio { get; set; }

        [Input("defaultScanLimitGbytes")]
        public int? DefaultScanLimitGbytes { get; set; }

        [Input("defaultTimeframeEnd")]
        public string? DefaultTimeframeEnd { get; set; }

        [Input("defaultTimeframeStart")]
        public string? DefaultTimeframeStart { get; set; }

        [Input("fetchTimeoutSeconds")]
        public int? FetchTimeoutSeconds { get; set; }

        [Input("locale")]
        public string? Locale { get; set; }

        [Input("maxResultBytes")]
        public int? MaxResultBytes { get; set; }

        [Input("maxResultRecords")]
        public int? MaxResultRecords { get; set; }

        [Input("query", required: true)]
        public string Query { get; set; } = null!;

        [Input("timezone")]
        public string? Timezone { get; set; }

        public GetDqlArgs()
        {
        }
        public static new GetDqlArgs Empty => new GetDqlArgs();
    }

    public sealed class GetDqlInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("defaultSamplingRatio")]
        public Input<double>? DefaultSamplingRatio { get; set; }

        [Input("defaultScanLimitGbytes")]
        public Input<int>? DefaultScanLimitGbytes { get; set; }

        [Input("defaultTimeframeEnd")]
        public Input<string>? DefaultTimeframeEnd { get; set; }

        [Input("defaultTimeframeStart")]
        public Input<string>? DefaultTimeframeStart { get; set; }

        [Input("fetchTimeoutSeconds")]
        public Input<int>? FetchTimeoutSeconds { get; set; }

        [Input("locale")]
        public Input<string>? Locale { get; set; }

        [Input("maxResultBytes")]
        public Input<int>? MaxResultBytes { get; set; }

        [Input("maxResultRecords")]
        public Input<int>? MaxResultRecords { get; set; }

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        public GetDqlInvokeArgs()
        {
        }
        public static new GetDqlInvokeArgs Empty => new GetDqlInvokeArgs();
    }


    [OutputType]
    public sealed class GetDqlResult
    {
        public readonly double? DefaultSamplingRatio;
        public readonly int? DefaultScanLimitGbytes;
        public readonly string? DefaultTimeframeEnd;
        public readonly string? DefaultTimeframeStart;
        public readonly int? FetchTimeoutSeconds;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Locale;
        public readonly int? MaxResultBytes;
        public readonly int? MaxResultRecords;
        public readonly string Query;
        public readonly string Records;
        public readonly string? Timezone;

        [OutputConstructor]
        private GetDqlResult(
            double? defaultSamplingRatio,

            int? defaultScanLimitGbytes,

            string? defaultTimeframeEnd,

            string? defaultTimeframeStart,

            int? fetchTimeoutSeconds,

            string id,

            string? locale,

            int? maxResultBytes,

            int? maxResultRecords,

            string query,

            string records,

            string? timezone)
        {
            DefaultSamplingRatio = defaultSamplingRatio;
            DefaultScanLimitGbytes = defaultScanLimitGbytes;
            DefaultTimeframeEnd = defaultTimeframeEnd;
            DefaultTimeframeStart = defaultTimeframeStart;
            FetchTimeoutSeconds = fetchTimeoutSeconds;
            Id = id;
            Locale = locale;
            MaxResultBytes = maxResultBytes;
            MaxResultRecords = maxResultRecords;
            Query = query;
            Records = records;
            Timezone = timezone;
        }
    }
}
