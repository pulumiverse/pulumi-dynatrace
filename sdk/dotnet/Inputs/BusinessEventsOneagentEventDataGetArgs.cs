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

    public sealed class BusinessEventsOneagentEventDataGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("eventDataFieldComplexes", required: true)]
        private InputList<Inputs.BusinessEventsOneagentEventDataEventDataFieldComplexGetArgs>? _eventDataFieldComplexes;
        public InputList<Inputs.BusinessEventsOneagentEventDataEventDataFieldComplexGetArgs> EventDataFieldComplexes
        {
            get => _eventDataFieldComplexes ?? (_eventDataFieldComplexes = new InputList<Inputs.BusinessEventsOneagentEventDataEventDataFieldComplexGetArgs>());
            set => _eventDataFieldComplexes = value;
        }

        public BusinessEventsOneagentEventDataGetArgs()
        {
        }
        public static new BusinessEventsOneagentEventDataGetArgs Empty => new BusinessEventsOneagentEventDataGetArgs();
    }
}
