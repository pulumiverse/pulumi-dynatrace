// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class GetDocumentsValueResult
    {
        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the document.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The owner of the document. This could be a user or a group that has ownership rights over the document.
        /// </summary>
        public readonly string Owner;
        /// <summary>
        /// The type of the document. This could be a specific format or category the document belongs to.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDocumentsValueResult(
            string id,

            string name,

            string owner,

            string type)
        {
            Id = id;
            Name = name;
            Owner = owner;
            Type = type;
        }
    }
}