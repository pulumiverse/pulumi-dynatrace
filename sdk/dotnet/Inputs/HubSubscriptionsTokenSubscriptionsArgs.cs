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

    public sealed class HubSubscriptionsTokenSubscriptionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("tokenSubscriptions", required: true)]
        private InputList<Inputs.HubSubscriptionsTokenSubscriptionsTokenSubscriptionArgs>? _tokenSubscriptions;
        public InputList<Inputs.HubSubscriptionsTokenSubscriptionsTokenSubscriptionArgs> TokenSubscriptions
        {
            get => _tokenSubscriptions ?? (_tokenSubscriptions = new InputList<Inputs.HubSubscriptionsTokenSubscriptionsTokenSubscriptionArgs>());
            set => _tokenSubscriptions = value;
        }

        public HubSubscriptionsTokenSubscriptionsArgs()
        {
        }
        public static new HubSubscriptionsTokenSubscriptionsArgs Empty => new HubSubscriptionsTokenSubscriptionsArgs();
    }
}