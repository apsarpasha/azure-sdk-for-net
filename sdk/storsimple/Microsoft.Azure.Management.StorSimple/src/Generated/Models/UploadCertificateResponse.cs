// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Upload Certificate Response from IDM
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UploadCertificateResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the UploadCertificateResponse class.
        /// </summary>
        public UploadCertificateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UploadCertificateResponse class.
        /// </summary>
        /// <param name="certificate">Gets or sets the base64 encoded
        /// certificate raw data string</param>
        /// <param name="resourceId">Gets or Sets the ResourceId</param>
        /// <param name="aadAuthority">AAD tenant authority</param>
        /// <param name="aadTenantId">AAD tenant Id</param>
        /// <param name="servicePrincipalClientId">AAD service principal
        /// clientId</param>
        /// <param name="servicePrincipalObjectId">AAD service principal
        /// ObjectId</param>
        /// <param name="azureManagementEndpointAudience">Azure Management
        /// Endpoint Audience</param>
        /// <param name="subject">Certificate Subject Name</param>
        /// <param name="validFrom">Certificate Validity start Date
        /// time</param>
        /// <param name="validTo">Certificate Validity End Date time</param>
        /// <param name="thumbprint">Certificate thumbrprint</param>
        /// <param name="friendlyName">Certificate friendlyname</param>
        /// <param name="issuer">Certificate issuer</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="authType">Specify the Authentication type. Possible
        /// values include: 'Invalid', 'AccessControlService',
        /// 'AzureActiveDirectory'</param>
        public UploadCertificateResponse(string certificate, long resourceId, string aadAuthority, string aadTenantId, string servicePrincipalClientId, string servicePrincipalObjectId, string azureManagementEndpointAudience, string subject, System.DateTime validFrom, System.DateTime validTo, string thumbprint, string friendlyName, string issuer, string id = default(string), string name = default(string), string type = default(string), AuthType? authType = default(AuthType?))
            : base(id, name, type)
        {
            AuthType = authType;
            Certificate = certificate;
            ResourceId = resourceId;
            AadAuthority = aadAuthority;
            AadTenantId = aadTenantId;
            ServicePrincipalClientId = servicePrincipalClientId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            AzureManagementEndpointAudience = azureManagementEndpointAudience;
            Subject = subject;
            ValidFrom = validFrom;
            ValidTo = validTo;
            Thumbprint = thumbprint;
            FriendlyName = friendlyName;
            Issuer = issuer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specify the Authentication type. Possible values
        /// include: 'Invalid', 'AccessControlService', 'AzureActiveDirectory'
        /// </summary>
        [JsonProperty(PropertyName = "properties.authType")]
        public AuthType? AuthType { get; set; }

        /// <summary>
        /// Gets or sets the base64 encoded certificate raw data string
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or Sets the ResourceId
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public long ResourceId { get; set; }

        /// <summary>
        /// Gets or sets AAD tenant authority
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadAuthority")]
        public string AadAuthority { get; set; }

        /// <summary>
        /// Gets or sets AAD tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadTenantId")]
        public string AadTenantId { get; set; }

        /// <summary>
        /// Gets or sets AAD service principal clientId
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePrincipalClientId")]
        public string ServicePrincipalClientId { get; set; }

        /// <summary>
        /// Gets or sets AAD service principal ObjectId
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePrincipalObjectId")]
        public string ServicePrincipalObjectId { get; set; }

        /// <summary>
        /// Gets or sets azure Management Endpoint Audience
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureManagementEndpointAudience")]
        public string AzureManagementEndpointAudience { get; set; }

        /// <summary>
        /// Gets or sets certificate Subject Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets certificate Validity start Date time
        /// </summary>
        [JsonProperty(PropertyName = "properties.validFrom")]
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets certificate Validity End Date time
        /// </summary>
        [JsonProperty(PropertyName = "properties.validTo")]
        public System.DateTime ValidTo { get; set; }

        /// <summary>
        /// Gets or sets certificate thumbrprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets certificate friendlyname
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets certificate issuer
        /// </summary>
        [JsonProperty(PropertyName = "properties.issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Certificate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Certificate");
            }
            if (AadAuthority == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AadAuthority");
            }
            if (AadTenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AadTenantId");
            }
            if (ServicePrincipalClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalClientId");
            }
            if (ServicePrincipalObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalObjectId");
            }
            if (AzureManagementEndpointAudience == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureManagementEndpointAudience");
            }
            if (Subject == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subject");
            }
            if (Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Thumbprint");
            }
            if (FriendlyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FriendlyName");
            }
            if (Issuer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Issuer");
            }
        }
    }
}
