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

    public sealed class ImsBridgesQueueManagerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("queueManagers")]
        private InputList<Inputs.ImsBridgesQueueManagerQueueManagerGetArgs>? _queueManagers;

        /// <summary>
        /// Queue manager definition for IMS bridge
        /// </summary>
        public InputList<Inputs.ImsBridgesQueueManagerQueueManagerGetArgs> QueueManagers
        {
            get => _queueManagers ?? (_queueManagers = new InputList<Inputs.ImsBridgesQueueManagerQueueManagerGetArgs>());
            set => _queueManagers = value;
        }

        public ImsBridgesQueueManagerGetArgs()
        {
        }
        public static new ImsBridgesQueueManagerGetArgs Empty => new ImsBridgesQueueManagerGetArgs();
    }
}