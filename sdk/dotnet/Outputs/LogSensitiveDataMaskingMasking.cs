// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class LogSensitiveDataMaskingMasking
    {
        /// <summary>
        /// Maximum one capture group is allowed. If none was given, the whole expression will be treated as a capture group.
        /// </summary>
        public readonly string Expression;
        /// <summary>
        /// The string to replace the masked expression with. Irrelevant if `type` is `SHA1`.
        /// </summary>
        public readonly string? Replacement;
        /// <summary>
        /// Possible Values: `SHA1`, `STRING`
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private LogSensitiveDataMaskingMasking(
            string expression,

            string? replacement,

            string type)
        {
            Expression = expression;
            Replacement = replacement;
            Type = type;
        }
    }
}
