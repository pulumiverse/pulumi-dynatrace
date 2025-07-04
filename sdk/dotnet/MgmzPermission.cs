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
    [DynatraceResourceType("dynatrace:index/mgmzPermission:MgmzPermission")]
    public partial class MgmzPermission : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The UUID of the environment
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// The ID of the group the permissions are valid for. You may refer to the id of a resource `dynatrace.UserGroup` here
        /// </summary>
        [Output("group")]
        public Output<string> Group { get; private set; } = null!;

        /// <summary>
        /// The ID of the management zone the permissions are valid for. When referring to resource `dynatrace.ManagementZoneV2` or data source `dynatrace.ManagementZone` you need to refer to the attribute `legacy_id`.
        /// </summary>
        [Output("managementZone")]
        public Output<string> ManagementZone { get; private set; } = null!;

        /// <summary>
        /// The permissions to assign for that management zone. Allowed values are `DEMO_USER`, `LOG_VIEWER`, `MANAGE_SECURITY_PROBLEMS`, `MANAGE_SETTINGS`, `REPLAY_SESSION_DATA`, `REPLAY_SESSION_DATA_WITHOUT_MASKING`, `VIEWER`, `VIEW_SENSITIVE_REQUEST_DATA`.
        /// Note: In order to produce non-empty plans specifying at least the permission `VIEWER` is recommended. Your Dynatrace Cluster will enforce that permission, regardless of whether it has been specified or not.
        /// </summary>
        [Output("permissions")]
        public Output<ImmutableArray<string>> Permissions { get; private set; } = null!;


        /// <summary>
        /// Create a MgmzPermission resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MgmzPermission(string name, MgmzPermissionArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/mgmzPermission:MgmzPermission", name, args ?? new MgmzPermissionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MgmzPermission(string name, Input<string> id, MgmzPermissionState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/mgmzPermission:MgmzPermission", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MgmzPermission resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MgmzPermission Get(string name, Input<string> id, MgmzPermissionState? state = null, CustomResourceOptions? options = null)
        {
            return new MgmzPermission(name, id, state, options);
        }
    }

    public sealed class MgmzPermissionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The UUID of the environment
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The ID of the group the permissions are valid for. You may refer to the id of a resource `dynatrace.UserGroup` here
        /// </summary>
        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        /// <summary>
        /// The ID of the management zone the permissions are valid for. When referring to resource `dynatrace.ManagementZoneV2` or data source `dynatrace.ManagementZone` you need to refer to the attribute `legacy_id`.
        /// </summary>
        [Input("managementZone", required: true)]
        public Input<string> ManagementZone { get; set; } = null!;

        [Input("permissions", required: true)]
        private InputList<string>? _permissions;

        /// <summary>
        /// The permissions to assign for that management zone. Allowed values are `DEMO_USER`, `LOG_VIEWER`, `MANAGE_SECURITY_PROBLEMS`, `MANAGE_SETTINGS`, `REPLAY_SESSION_DATA`, `REPLAY_SESSION_DATA_WITHOUT_MASKING`, `VIEWER`, `VIEW_SENSITIVE_REQUEST_DATA`.
        /// Note: In order to produce non-empty plans specifying at least the permission `VIEWER` is recommended. Your Dynatrace Cluster will enforce that permission, regardless of whether it has been specified or not.
        /// </summary>
        public InputList<string> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<string>());
            set => _permissions = value;
        }

        public MgmzPermissionArgs()
        {
        }
        public static new MgmzPermissionArgs Empty => new MgmzPermissionArgs();
    }

    public sealed class MgmzPermissionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The UUID of the environment
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The ID of the group the permissions are valid for. You may refer to the id of a resource `dynatrace.UserGroup` here
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        /// <summary>
        /// The ID of the management zone the permissions are valid for. When referring to resource `dynatrace.ManagementZoneV2` or data source `dynatrace.ManagementZone` you need to refer to the attribute `legacy_id`.
        /// </summary>
        [Input("managementZone")]
        public Input<string>? ManagementZone { get; set; }

        [Input("permissions")]
        private InputList<string>? _permissions;

        /// <summary>
        /// The permissions to assign for that management zone. Allowed values are `DEMO_USER`, `LOG_VIEWER`, `MANAGE_SECURITY_PROBLEMS`, `MANAGE_SETTINGS`, `REPLAY_SESSION_DATA`, `REPLAY_SESSION_DATA_WITHOUT_MASKING`, `VIEWER`, `VIEW_SENSITIVE_REQUEST_DATA`.
        /// Note: In order to produce non-empty plans specifying at least the permission `VIEWER` is recommended. Your Dynatrace Cluster will enforce that permission, regardless of whether it has been specified or not.
        /// </summary>
        public InputList<string> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<string>());
            set => _permissions = value;
        }

        public MgmzPermissionState()
        {
        }
        public static new MgmzPermissionState Empty => new MgmzPermissionState();
    }
}
