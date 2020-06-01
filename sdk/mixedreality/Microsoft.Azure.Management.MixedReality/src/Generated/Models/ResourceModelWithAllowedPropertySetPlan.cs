// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality.Models
{
    using System.Linq;

    public partial class ResourceModelWithAllowedPropertySetPlan : Plan
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetPlan class.
        /// </summary>
        public ResourceModelWithAllowedPropertySetPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetPlan class.
        /// </summary>
        /// <param name="name">A user defined name of the 3rd Party Artifact
        /// that is being procured.</param>
        /// <param name="publisher">The publisher of the 3rd Party Artifact
        /// that is being bought. E.g. NewRelic</param>
        /// <param name="product">The 3rd Party artifact that is being
        /// procured. E.g. NewRelic. Product maps to the OfferID specified for
        /// the artifact at the time of Data Market onboarding. </param>
        /// <param name="promotionCode">A publisher provided promotion code as
        /// provisioned in Data Market for the said product/artifact.</param>
        /// <param name="version">The version of the desired
        /// product/artifact.</param>
        public ResourceModelWithAllowedPropertySetPlan(string name, string publisher, string product, string promotionCode = default(string), string version = default(string))
            : base(name, publisher, product, promotionCode, version)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
