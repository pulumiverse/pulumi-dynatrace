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

    public sealed class CredentialsAllowedEntitiesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("entities", required: true)]
        private InputList<Inputs.CredentialsAllowedEntitiesEntityGetArgs>? _entities;

        /// <summary>
        /// The set of entities allowed to use the credential.
        /// </summary>
        public InputList<Inputs.CredentialsAllowedEntitiesEntityGetArgs> Entities
        {
            get => _entities ?? (_entities = new InputList<Inputs.CredentialsAllowedEntitiesEntityGetArgs>());
            set => _entities = value;
        }

        public CredentialsAllowedEntitiesGetArgs()
        {
        }
        public static new CredentialsAllowedEntitiesGetArgs Empty => new CredentialsAllowedEntitiesGetArgs();
    }
}