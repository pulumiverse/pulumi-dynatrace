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

    public sealed class MobileApplicationPropertiesArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiValues")]
        private InputList<Inputs.MobileApplicationPropertiesApiValueArgs>? _apiValues;

        /// <summary>
        /// A User Action / Session Property based on a value reported by the API
        /// </summary>
        public InputList<Inputs.MobileApplicationPropertiesApiValueArgs> ApiValues
        {
            get => _apiValues ?? (_apiValues = new InputList<Inputs.MobileApplicationPropertiesApiValueArgs>());
            set => _apiValues = value;
        }

        [Input("requestAttributes")]
        private InputList<Inputs.MobileApplicationPropertiesRequestAttributeArgs>? _requestAttributes;

        /// <summary>
        /// A User Action / Session Property based on a Server Side Request Attribute
        /// </summary>
        public InputList<Inputs.MobileApplicationPropertiesRequestAttributeArgs> RequestAttributes
        {
            get => _requestAttributes ?? (_requestAttributes = new InputList<Inputs.MobileApplicationPropertiesRequestAttributeArgs>());
            set => _requestAttributes = value;
        }

        public MobileApplicationPropertiesArgs()
        {
        }
        public static new MobileApplicationPropertiesArgs Empty => new MobileApplicationPropertiesArgs();
    }
}