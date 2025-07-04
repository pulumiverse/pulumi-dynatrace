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
    /// <summary>
    /// &gt; This resource requires the API token scopes **Read settings** (`settings.read`) and **Write settings** (`settings.write`)
    /// 
    /// ## Dynatrace Documentation
    /// 
    /// - Trace sampling - https://docs.dynatrace.com/docs/shortlink/url-sampling
    /// 
    /// - Settings API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/settings (schemaId: `builtin:rpc-based-sampling`)
    /// 
    /// ## Resource Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Dynatrace = Pulumiverse.Dynatrace;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var _name_ = new Dynatrace.RpcBasedSampling("#name#", new()
    ///     {
    ///         Enabled = false,
    ///         EndpointName = "#name#-endpoint",
    ///         EndpointNameComparisonType = "DOES_NOT_END_WITH",
    ///         Ignore = true,
    ///         RemoteOperationName = "#name#-operation",
    ///         RemoteOperationNameComparisonType = "CONTAINS",
    ///         RemoteServiceName = "#name#-service",
    ///         RemoteServiceNameComparisonType = "STARTS_WITH",
    ///         Scope = "environment",
    ///         WireProtocolType = "8",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [DynatraceResourceType("dynatrace:index/rpcBasedSampling:RpcBasedSampling")]
    public partial class RpcBasedSampling : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Specify the RPC endpoint name. If the endpoint name is empty, either remote operation name or remote service name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Output("endpointName")]
        public Output<string?> EndpointName { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Output("endpointNameComparisonType")]
        public Output<string> EndpointNameComparisonType { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `0`, `1`, `2`, `3`, `4`, `5`, `6`, `8`, `9`, `10`, `11`, `12`, `13`, `14` - `0`: Increase capturing 128
        /// times - `1`: Increase capturing 64 times - `2`: Increase capturing 32 times - `3`: Increase capturing 16 times - `4`:
        /// Increase capturing 8 times - `5`: Increase capturing 4 times - `6`: Increase capturing 2 times - `8`: Reduce capturing
        /// by factor 2 - `9`: Reduce capturing by factor 4 - `10`: Reduce capturing by factor 8 - `11`: Reduce capturing by factor
        /// 16 - `12`: Reduce capturing by factor 32 - `13`: Reduce capturing by factor 64 - `14`: Reduce capturing by factor 128
        /// </summary>
        [Output("factor")]
        public Output<string?> Factor { get; private set; } = null!;

        /// <summary>
        /// No Traces will be captured for matching RPC requests. This applies always, even if Adaptive Traffic Management is
        /// inactive.
        /// </summary>
        [Output("ignore")]
        public Output<bool> Ignore { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Specify the RPC operation name. If the remote operation name is empty, either remote service name or endpoint name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Output("remoteOperationName")]
        public Output<string?> RemoteOperationName { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Output("remoteOperationNameComparisonType")]
        public Output<string> RemoteOperationNameComparisonType { get; private set; } = null!;

        /// <summary>
        /// Specify the RPC remote service name. If the remote service name is empty, either remote operation name or endpoint name
        /// must be specified that can be used for RPC matching.
        /// </summary>
        [Output("remoteServiceName")]
        public Output<string?> RemoteServiceName { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Output("remoteServiceNameComparisonType")]
        public Output<string> RemoteServiceNameComparisonType { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (PROCESS_GROUP_INSTANCE, PROCESS_GROUP, CLOUD_APPLICATION, CLOUD_APPLICATION_NAMESPACE,
        /// KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10` - `1`: ADK - `2`: DOTNET_REMOTING - `3`:
        /// DOTNET_REMOTING_TCP - `4`: DOTNET_REMOTING_HTTP - `5`: DOTNET_REMOTING_XMLRPC - `6`: GRPC - `7`: GRPC_BIDI - `8`:
        /// GRPC_UNARY - `9`: GRPC_SERVERSTREAM - `10`: GRPC_CLIENTSTREAM
        /// </summary>
        [Output("wireProtocolType")]
        public Output<string> WireProtocolType { get; private set; } = null!;


        /// <summary>
        /// Create a RpcBasedSampling resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RpcBasedSampling(string name, RpcBasedSamplingArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/rpcBasedSampling:RpcBasedSampling", name, args ?? new RpcBasedSamplingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RpcBasedSampling(string name, Input<string> id, RpcBasedSamplingState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/rpcBasedSampling:RpcBasedSampling", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RpcBasedSampling resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RpcBasedSampling Get(string name, Input<string> id, RpcBasedSamplingState? state = null, CustomResourceOptions? options = null)
        {
            return new RpcBasedSampling(name, id, state, options);
        }
    }

    public sealed class RpcBasedSamplingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Specify the RPC endpoint name. If the endpoint name is empty, either remote operation name or remote service name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Input("endpointName")]
        public Input<string>? EndpointName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("endpointNameComparisonType", required: true)]
        public Input<string> EndpointNameComparisonType { get; set; } = null!;

        /// <summary>
        /// Possible Values: `0`, `1`, `2`, `3`, `4`, `5`, `6`, `8`, `9`, `10`, `11`, `12`, `13`, `14` - `0`: Increase capturing 128
        /// times - `1`: Increase capturing 64 times - `2`: Increase capturing 32 times - `3`: Increase capturing 16 times - `4`:
        /// Increase capturing 8 times - `5`: Increase capturing 4 times - `6`: Increase capturing 2 times - `8`: Reduce capturing
        /// by factor 2 - `9`: Reduce capturing by factor 4 - `10`: Reduce capturing by factor 8 - `11`: Reduce capturing by factor
        /// 16 - `12`: Reduce capturing by factor 32 - `13`: Reduce capturing by factor 64 - `14`: Reduce capturing by factor 128
        /// </summary>
        [Input("factor")]
        public Input<string>? Factor { get; set; }

        /// <summary>
        /// No Traces will be captured for matching RPC requests. This applies always, even if Adaptive Traffic Management is
        /// inactive.
        /// </summary>
        [Input("ignore", required: true)]
        public Input<bool> Ignore { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Specify the RPC operation name. If the remote operation name is empty, either remote service name or endpoint name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Input("remoteOperationName")]
        public Input<string>? RemoteOperationName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("remoteOperationNameComparisonType", required: true)]
        public Input<string> RemoteOperationNameComparisonType { get; set; } = null!;

        /// <summary>
        /// Specify the RPC remote service name. If the remote service name is empty, either remote operation name or endpoint name
        /// must be specified that can be used for RPC matching.
        /// </summary>
        [Input("remoteServiceName")]
        public Input<string>? RemoteServiceName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("remoteServiceNameComparisonType", required: true)]
        public Input<string> RemoteServiceNameComparisonType { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (PROCESS_GROUP_INSTANCE, PROCESS_GROUP, CLOUD_APPLICATION, CLOUD_APPLICATION_NAMESPACE,
        /// KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Possible Values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10` - `1`: ADK - `2`: DOTNET_REMOTING - `3`:
        /// DOTNET_REMOTING_TCP - `4`: DOTNET_REMOTING_HTTP - `5`: DOTNET_REMOTING_XMLRPC - `6`: GRPC - `7`: GRPC_BIDI - `8`:
        /// GRPC_UNARY - `9`: GRPC_SERVERSTREAM - `10`: GRPC_CLIENTSTREAM
        /// </summary>
        [Input("wireProtocolType", required: true)]
        public Input<string> WireProtocolType { get; set; } = null!;

        public RpcBasedSamplingArgs()
        {
        }
        public static new RpcBasedSamplingArgs Empty => new RpcBasedSamplingArgs();
    }

    public sealed class RpcBasedSamplingState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Specify the RPC endpoint name. If the endpoint name is empty, either remote operation name or remote service name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Input("endpointName")]
        public Input<string>? EndpointName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("endpointNameComparisonType")]
        public Input<string>? EndpointNameComparisonType { get; set; }

        /// <summary>
        /// Possible Values: `0`, `1`, `2`, `3`, `4`, `5`, `6`, `8`, `9`, `10`, `11`, `12`, `13`, `14` - `0`: Increase capturing 128
        /// times - `1`: Increase capturing 64 times - `2`: Increase capturing 32 times - `3`: Increase capturing 16 times - `4`:
        /// Increase capturing 8 times - `5`: Increase capturing 4 times - `6`: Increase capturing 2 times - `8`: Reduce capturing
        /// by factor 2 - `9`: Reduce capturing by factor 4 - `10`: Reduce capturing by factor 8 - `11`: Reduce capturing by factor
        /// 16 - `12`: Reduce capturing by factor 32 - `13`: Reduce capturing by factor 64 - `14`: Reduce capturing by factor 128
        /// </summary>
        [Input("factor")]
        public Input<string>? Factor { get; set; }

        /// <summary>
        /// No Traces will be captured for matching RPC requests. This applies always, even if Adaptive Traffic Management is
        /// inactive.
        /// </summary>
        [Input("ignore")]
        public Input<bool>? Ignore { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Specify the RPC operation name. If the remote operation name is empty, either remote service name or endpoint name must
        /// be specified that can be used for RPC matching.
        /// </summary>
        [Input("remoteOperationName")]
        public Input<string>? RemoteOperationName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("remoteOperationNameComparisonType")]
        public Input<string>? RemoteOperationNameComparisonType { get; set; }

        /// <summary>
        /// Specify the RPC remote service name. If the remote service name is empty, either remote operation name or endpoint name
        /// must be specified that can be used for RPC matching.
        /// </summary>
        [Input("remoteServiceName")]
        public Input<string>? RemoteServiceName { get; set; }

        /// <summary>
        /// Possible Values: `CONTAINS`, `DOES_NOT_CONTAIN`, `DOES_NOT_END_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`,
        /// `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("remoteServiceNameComparisonType")]
        public Input<string>? RemoteServiceNameComparisonType { get; set; }

        /// <summary>
        /// The scope of this setting (PROCESS_GROUP_INSTANCE, PROCESS_GROUP, CLOUD_APPLICATION, CLOUD_APPLICATION_NAMESPACE,
        /// KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Possible Values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10` - `1`: ADK - `2`: DOTNET_REMOTING - `3`:
        /// DOTNET_REMOTING_TCP - `4`: DOTNET_REMOTING_HTTP - `5`: DOTNET_REMOTING_XMLRPC - `6`: GRPC - `7`: GRPC_BIDI - `8`:
        /// GRPC_UNARY - `9`: GRPC_SERVERSTREAM - `10`: GRPC_CLIENTSTREAM
        /// </summary>
        [Input("wireProtocolType")]
        public Input<string>? WireProtocolType { get; set; }

        public RpcBasedSamplingState()
        {
        }
        public static new RpcBasedSamplingState Empty => new RpcBasedSamplingState();
    }
}
