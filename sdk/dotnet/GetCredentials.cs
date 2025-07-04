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
    public static class GetCredentials
    {
        /// <summary>
        /// The `dynatrace.Credentials` data source queries for Credentials stored within the Credentials Vault using the properties `name`, `scope` and `type`. At least one of `name`, `scope` or `type` needs to be specified as a non empty value. Combinations of the three properties are also possible.
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
        ///     var creds = Dynatrace.GetCredentials.Invoke(new()
        ///     {
        ///         Name = "Office365 Access Token",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.HttpMonitor("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         Frequency = 60,
        ///         Locations = new[]
        ///         {
        ///             "SYNTHETIC_LOCATION-781752216580B1BC",
        ///         },
        ///         AnomalyDetections = new[]
        ///         {
        ///             new Dynatrace.Inputs.HttpMonitorAnomalyDetectionArgs
        ///             {
        ///                 LoadingTimeThresholds = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdArgs
        ///                     {
        ///                         Enabled = true,
        ///                     },
        ///                 },
        ///                 OutageHandlings = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionOutageHandlingArgs
        ///                     {
        ///                         GlobalOutage = true,
        ///                         LocalOutage = false,
        ///                         RetryOnError = false,
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         Script = new Dynatrace.Inputs.HttpMonitorScriptArgs
        ///         {
        ///             Requests = new[]
        ///             {
        ///                 new Dynatrace.Inputs.HttpMonitorScriptRequestArgs
        ///                 {
        ///                     Description = "google.com",
        ///                     Method = "GET",
        ///                     Url = "https://www.google.com",
        ///                     Authentication = new Dynatrace.Inputs.HttpMonitorScriptRequestAuthenticationArgs
        ///                     {
        ///                         Type = "BASIC_AUTHENTICATION",
        ///                         Credentials = creds.Apply(getCredentialsResult =&gt; getCredentialsResult.Id),
        ///                     },
        ///                     Configuration = new Dynatrace.Inputs.HttpMonitorScriptRequestConfigurationArgs
        ///                     {
        ///                         AcceptAnyCertificate = true,
        ///                         FollowRedirects = true,
        ///                     },
        ///                     Validation = new Dynatrace.Inputs.HttpMonitorScriptRequestValidationArgs
        ///                     {
        ///                         Rules = new[]
        ///                         {
        ///                             new Dynatrace.Inputs.HttpMonitorScriptRequestValidationRuleArgs
        ///                             {
        ///                                 Type = "httpStatusesList",
        ///                                 PassIfFound = false,
        ///                                 Value = "&gt;=400",
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetCredentialsResult> InvokeAsync(GetCredentialsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCredentialsResult>("dynatrace:index/getCredentials:getCredentials", args ?? new GetCredentialsArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.Credentials` data source queries for Credentials stored within the Credentials Vault using the properties `name`, `scope` and `type`. At least one of `name`, `scope` or `type` needs to be specified as a non empty value. Combinations of the three properties are also possible.
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
        ///     var creds = Dynatrace.GetCredentials.Invoke(new()
        ///     {
        ///         Name = "Office365 Access Token",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.HttpMonitor("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         Frequency = 60,
        ///         Locations = new[]
        ///         {
        ///             "SYNTHETIC_LOCATION-781752216580B1BC",
        ///         },
        ///         AnomalyDetections = new[]
        ///         {
        ///             new Dynatrace.Inputs.HttpMonitorAnomalyDetectionArgs
        ///             {
        ///                 LoadingTimeThresholds = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdArgs
        ///                     {
        ///                         Enabled = true,
        ///                     },
        ///                 },
        ///                 OutageHandlings = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionOutageHandlingArgs
        ///                     {
        ///                         GlobalOutage = true,
        ///                         LocalOutage = false,
        ///                         RetryOnError = false,
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         Script = new Dynatrace.Inputs.HttpMonitorScriptArgs
        ///         {
        ///             Requests = new[]
        ///             {
        ///                 new Dynatrace.Inputs.HttpMonitorScriptRequestArgs
        ///                 {
        ///                     Description = "google.com",
        ///                     Method = "GET",
        ///                     Url = "https://www.google.com",
        ///                     Authentication = new Dynatrace.Inputs.HttpMonitorScriptRequestAuthenticationArgs
        ///                     {
        ///                         Type = "BASIC_AUTHENTICATION",
        ///                         Credentials = creds.Apply(getCredentialsResult =&gt; getCredentialsResult.Id),
        ///                     },
        ///                     Configuration = new Dynatrace.Inputs.HttpMonitorScriptRequestConfigurationArgs
        ///                     {
        ///                         AcceptAnyCertificate = true,
        ///                         FollowRedirects = true,
        ///                     },
        ///                     Validation = new Dynatrace.Inputs.HttpMonitorScriptRequestValidationArgs
        ///                     {
        ///                         Rules = new[]
        ///                         {
        ///                             new Dynatrace.Inputs.HttpMonitorScriptRequestValidationRuleArgs
        ///                             {
        ///                                 Type = "httpStatusesList",
        ///                                 PassIfFound = false,
        ///                                 Value = "&gt;=400",
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetCredentialsResult> Invoke(GetCredentialsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCredentialsResult>("dynatrace:index/getCredentials:getCredentials", args ?? new GetCredentialsInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The `dynatrace.Credentials` data source queries for Credentials stored within the Credentials Vault using the properties `name`, `scope` and `type`. At least one of `name`, `scope` or `type` needs to be specified as a non empty value. Combinations of the three properties are also possible.
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
        ///     var creds = Dynatrace.GetCredentials.Invoke(new()
        ///     {
        ///         Name = "Office365 Access Token",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.HttpMonitor("#name#", new()
        ///     {
        ///         Enabled = true,
        ///         Frequency = 60,
        ///         Locations = new[]
        ///         {
        ///             "SYNTHETIC_LOCATION-781752216580B1BC",
        ///         },
        ///         AnomalyDetections = new[]
        ///         {
        ///             new Dynatrace.Inputs.HttpMonitorAnomalyDetectionArgs
        ///             {
        ///                 LoadingTimeThresholds = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdArgs
        ///                     {
        ///                         Enabled = true,
        ///                     },
        ///                 },
        ///                 OutageHandlings = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.HttpMonitorAnomalyDetectionOutageHandlingArgs
        ///                     {
        ///                         GlobalOutage = true,
        ///                         LocalOutage = false,
        ///                         RetryOnError = false,
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         Script = new Dynatrace.Inputs.HttpMonitorScriptArgs
        ///         {
        ///             Requests = new[]
        ///             {
        ///                 new Dynatrace.Inputs.HttpMonitorScriptRequestArgs
        ///                 {
        ///                     Description = "google.com",
        ///                     Method = "GET",
        ///                     Url = "https://www.google.com",
        ///                     Authentication = new Dynatrace.Inputs.HttpMonitorScriptRequestAuthenticationArgs
        ///                     {
        ///                         Type = "BASIC_AUTHENTICATION",
        ///                         Credentials = creds.Apply(getCredentialsResult =&gt; getCredentialsResult.Id),
        ///                     },
        ///                     Configuration = new Dynatrace.Inputs.HttpMonitorScriptRequestConfigurationArgs
        ///                     {
        ///                         AcceptAnyCertificate = true,
        ///                         FollowRedirects = true,
        ///                     },
        ///                     Validation = new Dynatrace.Inputs.HttpMonitorScriptRequestValidationArgs
        ///                     {
        ///                         Rules = new[]
        ///                         {
        ///                             new Dynatrace.Inputs.HttpMonitorScriptRequestValidationRuleArgs
        ///                             {
        ///                                 Type = "httpStatusesList",
        ///                                 PassIfFound = false,
        ///                                 Value = "&gt;=400",
        ///                             },
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetCredentialsResult> Invoke(GetCredentialsInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetCredentialsResult>("dynatrace:index/getCredentials:getCredentials", args ?? new GetCredentialsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCredentialsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
        /// </summary>
        [Input("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        public GetCredentialsArgs()
        {
        }
        public static new GetCredentialsArgs Empty => new GetCredentialsArgs();
    }

    public sealed class GetCredentialsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetCredentialsInvokeArgs()
        {
        }
        public static new GetCredentialsInvokeArgs Empty => new GetCredentialsInvokeArgs();
    }


    [OutputType]
    public sealed class GetCredentialsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetCredentialsResult(
            string id,

            string? name,

            string? scope,

            string? type)
        {
            Id = id;
            Name = name;
            Scope = scope;
            Type = type;
        }
    }
}
