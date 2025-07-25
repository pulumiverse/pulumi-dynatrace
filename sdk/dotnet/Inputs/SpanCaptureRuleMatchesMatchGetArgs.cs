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

    public sealed class SpanCaptureRuleMatchesMatchGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to match strings case sensitively or not
        /// </summary>
        [Input("caseSensitive")]
        public Input<bool>? CaseSensitive { get; set; }

        /// <summary>
        /// Possible values are `EQUALS`, `CONTAINS`, `STARTS_WITH`, `ENDS_WITH`, `DOES_NOT_EQUAL`, `DOES_NOT_CONTAIN`, `DOES_NOT_START_WITH` and `DOES_NOT_END_WITH`.
        /// </summary>
        [Input("comparison", required: true)]
        public Input<string> Comparison { get; set; } = null!;

        /// <summary>
        /// The name of the attribute if `source` is `ATTRIBUTE`
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// What to match against. Possible values are `SPAN_NAME`, `SPAN_KIND`, `ATTRIBUTE`, `INSTRUMENTATION_LIBRARY_NAME` and `INSTRUMENTATION_LIBRARY_VERSION`
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        /// <summary>
        /// The value to compare against. When `source` is `SPAN_KIND` the only allowed values are `INTERNAL`, `SERVER`, `CLIENT`, `PRODUCER` and `CONSUMER`
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public SpanCaptureRuleMatchesMatchGetArgs()
        {
        }
        public static new SpanCaptureRuleMatchesMatchGetArgs Empty => new SpanCaptureRuleMatchesMatchGetArgs();
    }
}
