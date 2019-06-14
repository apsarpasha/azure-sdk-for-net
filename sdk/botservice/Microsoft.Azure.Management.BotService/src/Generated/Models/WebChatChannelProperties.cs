// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the Web Chat channel.
    /// </summary>
    public partial class WebChatChannelProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebChatChannelProperties class.
        /// </summary>
        public WebChatChannelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebChatChannelProperties class.
        /// </summary>
        /// <param name="webChatEmbedCode">Web chat control embed code</param>
        /// <param name="sites">The list of Web Chat sites</param>
        public WebChatChannelProperties(string webChatEmbedCode = default(string), IList<WebChatSite> sites = default(IList<WebChatSite>))
        {
            WebChatEmbedCode = webChatEmbedCode;
            Sites = sites;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets web chat control embed code
        /// </summary>
        [JsonProperty(PropertyName = "webChatEmbedCode")]
        public string WebChatEmbedCode { get; private set; }

        /// <summary>
        /// Gets or sets the list of Web Chat sites
        /// </summary>
        [JsonProperty(PropertyName = "sites")]
        public IList<WebChatSite> Sites { get; set; }

    }
}