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
    [DynatraceResourceType("dynatrace:index/awsCredentials:AwsCredentials")]
    public partial class AwsCredentials : global::Pulumi.CustomResource
    {
        /// <summary>
        /// credentials for the AWS authentication
        /// </summary>
        [Output("authenticationData")]
        public Output<Outputs.AwsCredentialsAuthenticationData> AuthenticationData { get; private set; } = null!;

        /// <summary>
        /// The name of the credentials
        /// </summary>
        [Output("label")]
        public Output<string?> Label { get; private set; } = null!;

        /// <summary>
        /// The type of the AWS partition
        /// </summary>
        [Output("partitionType")]
        public Output<string> PartitionType { get; private set; } = null!;

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
        /// </summary>
        [Output("removeDefaults")]
        public Output<bool?> RemoveDefaults { get; private set; } = null!;

        [Output("supportingServicesManagedInDynatrace")]
        public Output<bool?> SupportingServicesManagedInDynatrace { get; private set; } = null!;

        /// <summary>
        /// supporting services to be monitored
        /// </summary>
        [Output("supportingServicesToMonitors")]
        public Output<ImmutableArray<Outputs.AwsCredentialsSupportingServicesToMonitor>> SupportingServicesToMonitors { get; private set; } = null!;

        /// <summary>
        /// Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
        /// </summary>
        [Output("taggedOnly")]
        public Output<bool> TaggedOnly { get; private set; } = null!;

        /// <summary>
        /// AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
        /// </summary>
        [Output("tagsToMonitors")]
        public Output<ImmutableArray<Outputs.AwsCredentialsTagsToMonitor>> TagsToMonitors { get; private set; } = null!;

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Output("unknowns")]
        public Output<string?> Unknowns { get; private set; } = null!;


        /// <summary>
        /// Create a AwsCredentials resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AwsCredentials(string name, AwsCredentialsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/awsCredentials:AwsCredentials", name, args ?? new AwsCredentialsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AwsCredentials(string name, Input<string> id, AwsCredentialsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/awsCredentials:AwsCredentials", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AwsCredentials resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AwsCredentials Get(string name, Input<string> id, AwsCredentialsState? state = null, CustomResourceOptions? options = null)
        {
            return new AwsCredentials(name, id, state, options);
        }
    }

    public sealed class AwsCredentialsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// credentials for the AWS authentication
        /// </summary>
        [Input("authenticationData", required: true)]
        public Input<Inputs.AwsCredentialsAuthenticationDataArgs> AuthenticationData { get; set; } = null!;

        /// <summary>
        /// The name of the credentials
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The type of the AWS partition
        /// </summary>
        [Input("partitionType", required: true)]
        public Input<string> PartitionType { get; set; } = null!;

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
        /// </summary>
        [Input("removeDefaults")]
        public Input<bool>? RemoveDefaults { get; set; }

        [Input("supportingServicesManagedInDynatrace")]
        public Input<bool>? SupportingServicesManagedInDynatrace { get; set; }

        [Input("supportingServicesToMonitors")]
        private InputList<Inputs.AwsCredentialsSupportingServicesToMonitorArgs>? _supportingServicesToMonitors;

        /// <summary>
        /// supporting services to be monitored
        /// </summary>
        [Obsolete(@"Managing supporting services directly within AWS Credentials has been deprecated within the REST API. This attribute just exists for backwards compatibility. It no longer has an effect. For managing services use the resource `dynatrace.AwsService`")]
        public InputList<Inputs.AwsCredentialsSupportingServicesToMonitorArgs> SupportingServicesToMonitors
        {
            get => _supportingServicesToMonitors ?? (_supportingServicesToMonitors = new InputList<Inputs.AwsCredentialsSupportingServicesToMonitorArgs>());
            set => _supportingServicesToMonitors = value;
        }

        /// <summary>
        /// Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
        /// </summary>
        [Input("taggedOnly", required: true)]
        public Input<bool> TaggedOnly { get; set; } = null!;

        [Input("tagsToMonitors")]
        private InputList<Inputs.AwsCredentialsTagsToMonitorArgs>? _tagsToMonitors;

        /// <summary>
        /// AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
        /// </summary>
        public InputList<Inputs.AwsCredentialsTagsToMonitorArgs> TagsToMonitors
        {
            get => _tagsToMonitors ?? (_tagsToMonitors = new InputList<Inputs.AwsCredentialsTagsToMonitorArgs>());
            set => _tagsToMonitors = value;
        }

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AwsCredentialsArgs()
        {
        }
        public static new AwsCredentialsArgs Empty => new AwsCredentialsArgs();
    }

    public sealed class AwsCredentialsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// credentials for the AWS authentication
        /// </summary>
        [Input("authenticationData")]
        public Input<Inputs.AwsCredentialsAuthenticationDataGetArgs>? AuthenticationData { get; set; }

        /// <summary>
        /// The name of the credentials
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The type of the AWS partition
        /// </summary>
        [Input("partitionType")]
        public Input<string>? PartitionType { get; set; }

        /// <summary>
        /// Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
        /// </summary>
        [Input("removeDefaults")]
        public Input<bool>? RemoveDefaults { get; set; }

        [Input("supportingServicesManagedInDynatrace")]
        public Input<bool>? SupportingServicesManagedInDynatrace { get; set; }

        [Input("supportingServicesToMonitors")]
        private InputList<Inputs.AwsCredentialsSupportingServicesToMonitorGetArgs>? _supportingServicesToMonitors;

        /// <summary>
        /// supporting services to be monitored
        /// </summary>
        [Obsolete(@"Managing supporting services directly within AWS Credentials has been deprecated within the REST API. This attribute just exists for backwards compatibility. It no longer has an effect. For managing services use the resource `dynatrace.AwsService`")]
        public InputList<Inputs.AwsCredentialsSupportingServicesToMonitorGetArgs> SupportingServicesToMonitors
        {
            get => _supportingServicesToMonitors ?? (_supportingServicesToMonitors = new InputList<Inputs.AwsCredentialsSupportingServicesToMonitorGetArgs>());
            set => _supportingServicesToMonitors = value;
        }

        /// <summary>
        /// Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
        /// </summary>
        [Input("taggedOnly")]
        public Input<bool>? TaggedOnly { get; set; }

        [Input("tagsToMonitors")]
        private InputList<Inputs.AwsCredentialsTagsToMonitorGetArgs>? _tagsToMonitors;

        /// <summary>
        /// AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
        /// </summary>
        public InputList<Inputs.AwsCredentialsTagsToMonitorGetArgs> TagsToMonitors
        {
            get => _tagsToMonitors ?? (_tagsToMonitors = new InputList<Inputs.AwsCredentialsTagsToMonitorGetArgs>());
            set => _tagsToMonitors = value;
        }

        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AwsCredentialsState()
        {
        }
        public static new AwsCredentialsState Empty => new AwsCredentialsState();
    }
}