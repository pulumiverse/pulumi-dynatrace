// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class BusinessEventsOneagentTriggersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("triggers", required: true)]
        private InputList<Inputs.BusinessEventsOneagentTriggersTriggerGetArgs>? _triggers;
        public InputList<Inputs.BusinessEventsOneagentTriggersTriggerGetArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.BusinessEventsOneagentTriggersTriggerGetArgs>());
            set => _triggers = value;
        }

        public BusinessEventsOneagentTriggersGetArgs()
        {
        }
        public static new BusinessEventsOneagentTriggersGetArgs Empty => new BusinessEventsOneagentTriggersGetArgs();
    }
}
