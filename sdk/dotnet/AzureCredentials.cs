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
    [DynatraceResourceType("dynatrace:index/azureCredentials:AzureCredentials")]
    public partial class AzureCredentials : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
        /// </summary>
        [Output("active")]
        public Output<bool> Active { get; private set; } = null!;

        /// <summary>
        /// The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Output("appId")]
        public Output<string?> AppId { get; private set; } = null!;

        /// <summary>
        /// The automatic capture of Azure tags is on (`true`) or off (`false`)
        /// </summary>
        [Output("autoTagging")]
        public Output<bool?> AutoTagging { get; private set; } = null!;

        /// <summary>
        /// The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Output("directoryId")]
        public Output<string?> DirectoryId { get; private set; } = null!;

        /// <summary>
        /// The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
        /// </summary>
        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        /// <summary>
        /// The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
        /// </summary>
        [Output("label")]
        public Output<string> Label { get; private set; } = null!;

        /// <summary>
        /// A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
        /// </summary>
        [Output("monitorOnlyExcludingTagPairs")]
        public Output<ImmutableArray<Outputs.AzureCredentialsMonitorOnlyExcludingTagPair>> MonitorOnlyExcludingTagPairs { get; private set; } = null!;

        /// <summary>
        /// A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
        /// </summary>
        [Output("monitorOnlyTagPairs")]
        public Output<ImmutableArray<Outputs.AzureCredentialsMonitorOnlyTagPair>> MonitorOnlyTagPairs { get; private set; } = null!;

        /// <summary>
        /// Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
        /// </summary>
        [Output("monitorOnlyTaggedEntities")]
        public Output<bool> MonitorOnlyTaggedEntities { get; private set; } = null!;

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
        /// </summary>
        [Output("removeDefaults")]
        public Output<bool?> RemoveDefaults { get; private set; } = null!;

        /// <summary>
        /// A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
        /// </summary>
        [Output("supportingServices")]
        public Output<ImmutableArray<Outputs.AzureCredentialsSupportingService>> SupportingServices { get; private set; } = null!;

        [Output("supportingServicesManagedInDynatrace")]
        public Output<bool?> SupportingServicesManagedInDynatrace { get; private set; } = null!;

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Output("unknowns")]
        public Output<string?> Unknowns { get; private set; } = null!;


        /// <summary>
        /// Create a AzureCredentials resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AzureCredentials(string name, AzureCredentialsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/azureCredentials:AzureCredentials", name, args ?? new AzureCredentialsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AzureCredentials(string name, Input<string> id, AzureCredentialsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/azureCredentials:AzureCredentials", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
                AdditionalSecretOutputs =
                {
                    "key",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AzureCredentials resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AzureCredentials Get(string name, Input<string> id, AzureCredentialsState? state = null, CustomResourceOptions? options = null)
        {
            return new AzureCredentials(name, id, state, options);
        }
    }

    public sealed class AzureCredentialsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        /// <summary>
        /// The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        /// <summary>
        /// The automatic capture of Azure tags is on (`true`) or off (`false`)
        /// </summary>
        [Input("autoTagging")]
        public Input<bool>? AutoTagging { get; set; }

        /// <summary>
        /// The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Input("directoryId")]
        public Input<string>? DirectoryId { get; set; }

        [Input("key")]
        private Input<string>? _key;

        /// <summary>
        /// The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
        /// </summary>
        public Input<string>? Key
        {
            get => _key;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _key = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
        /// </summary>
        [Input("label", required: true)]
        public Input<string> Label { get; set; } = null!;

        [Input("monitorOnlyExcludingTagPairs")]
        private InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairArgs>? _monitorOnlyExcludingTagPairs;

        /// <summary>
        /// A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
        /// </summary>
        public InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairArgs> MonitorOnlyExcludingTagPairs
        {
            get => _monitorOnlyExcludingTagPairs ?? (_monitorOnlyExcludingTagPairs = new InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairArgs>());
            set => _monitorOnlyExcludingTagPairs = value;
        }

        [Input("monitorOnlyTagPairs")]
        private InputList<Inputs.AzureCredentialsMonitorOnlyTagPairArgs>? _monitorOnlyTagPairs;

        /// <summary>
        /// A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
        /// </summary>
        public InputList<Inputs.AzureCredentialsMonitorOnlyTagPairArgs> MonitorOnlyTagPairs
        {
            get => _monitorOnlyTagPairs ?? (_monitorOnlyTagPairs = new InputList<Inputs.AzureCredentialsMonitorOnlyTagPairArgs>());
            set => _monitorOnlyTagPairs = value;
        }

        /// <summary>
        /// Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
        /// </summary>
        [Input("monitorOnlyTaggedEntities", required: true)]
        public Input<bool> MonitorOnlyTaggedEntities { get; set; } = null!;

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
        /// </summary>
        [Input("removeDefaults")]
        public Input<bool>? RemoveDefaults { get; set; }

        [Input("supportingServices")]
        private InputList<Inputs.AzureCredentialsSupportingServiceArgs>? _supportingServices;

        /// <summary>
        /// A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
        /// </summary>
        [Obsolete(@"Assigning supported services directly when creating Azure Credentials is deprecated. Use the resource `dynatrace.AzureService` instead.")]
        public InputList<Inputs.AzureCredentialsSupportingServiceArgs> SupportingServices
        {
            get => _supportingServices ?? (_supportingServices = new InputList<Inputs.AzureCredentialsSupportingServiceArgs>());
            set => _supportingServices = value;
        }

        [Input("supportingServicesManagedInDynatrace")]
        public Input<bool>? SupportingServicesManagedInDynatrace { get; set; }

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AzureCredentialsArgs()
        {
        }
        public static new AzureCredentialsArgs Empty => new AzureCredentialsArgs();
    }

    public sealed class AzureCredentialsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        /// <summary>
        /// The automatic capture of Azure tags is on (`true`) or off (`false`)
        /// </summary>
        [Input("autoTagging")]
        public Input<bool>? AutoTagging { get; set; }

        /// <summary>
        /// The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
        /// </summary>
        [Input("directoryId")]
        public Input<string>? DirectoryId { get; set; }

        [Input("key")]
        private Input<string>? _key;

        /// <summary>
        /// The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
        /// </summary>
        public Input<string>? Key
        {
            get => _key;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _key = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("monitorOnlyExcludingTagPairs")]
        private InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairGetArgs>? _monitorOnlyExcludingTagPairs;

        /// <summary>
        /// A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
        /// </summary>
        public InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairGetArgs> MonitorOnlyExcludingTagPairs
        {
            get => _monitorOnlyExcludingTagPairs ?? (_monitorOnlyExcludingTagPairs = new InputList<Inputs.AzureCredentialsMonitorOnlyExcludingTagPairGetArgs>());
            set => _monitorOnlyExcludingTagPairs = value;
        }

        [Input("monitorOnlyTagPairs")]
        private InputList<Inputs.AzureCredentialsMonitorOnlyTagPairGetArgs>? _monitorOnlyTagPairs;

        /// <summary>
        /// A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
        /// </summary>
        public InputList<Inputs.AzureCredentialsMonitorOnlyTagPairGetArgs> MonitorOnlyTagPairs
        {
            get => _monitorOnlyTagPairs ?? (_monitorOnlyTagPairs = new InputList<Inputs.AzureCredentialsMonitorOnlyTagPairGetArgs>());
            set => _monitorOnlyTagPairs = value;
        }

        /// <summary>
        /// Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
        /// </summary>
        [Input("monitorOnlyTaggedEntities")]
        public Input<bool>? MonitorOnlyTaggedEntities { get; set; }

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
        /// </summary>
        [Input("removeDefaults")]
        public Input<bool>? RemoveDefaults { get; set; }

        [Input("supportingServices")]
        private InputList<Inputs.AzureCredentialsSupportingServiceGetArgs>? _supportingServices;

        /// <summary>
        /// A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
        /// </summary>
        [Obsolete(@"Assigning supported services directly when creating Azure Credentials is deprecated. Use the resource `dynatrace.AzureService` instead.")]
        public InputList<Inputs.AzureCredentialsSupportingServiceGetArgs> SupportingServices
        {
            get => _supportingServices ?? (_supportingServices = new InputList<Inputs.AzureCredentialsSupportingServiceGetArgs>());
            set => _supportingServices = value;
        }

        [Input("supportingServicesManagedInDynatrace")]
        public Input<bool>? SupportingServicesManagedInDynatrace { get; set; }

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AzureCredentialsState()
        {
        }
        public static new AzureCredentialsState Empty => new AzureCredentialsState();
    }
}
