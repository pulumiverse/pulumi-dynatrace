// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class LogStorageMatchersMatcherGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `Container_name`, `Dt_entity_container_group`, `Dt_entity_process_group`, `Host_tag`, `K8s_container_name`, `K8s_deployment_name`, `K8s_namespace_name`, `Log_content`, `Log_source`, `Loglevel`, `Process_technology`, `Winlog_eventid`, `Winlog_opcode`, `Winlog_provider`, `Winlog_task`
        /// </summary>
        [Input("attribute", required: true)]
        public Input<string> Attribute { get; set; } = null!;

        /// <summary>
        /// Possible Values: `MATCHES`
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// no documentation available
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public LogStorageMatchersMatcherGetArgs()
        {
        }
        public static new LogStorageMatchersMatcherGetArgs Empty => new LogStorageMatchersMatcherGetArgs();
    }
}
