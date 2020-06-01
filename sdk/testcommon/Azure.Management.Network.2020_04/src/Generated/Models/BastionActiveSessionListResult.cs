// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for GetActiveSessions. </summary>
    public partial class BastionActiveSessionListResult
    {
        /// <summary> Initializes a new instance of BastionActiveSessionListResult. </summary>
        internal BastionActiveSessionListResult()
        {
        }

        /// <summary> Initializes a new instance of BastionActiveSessionListResult. </summary>
        /// <param name="value"> List of active sessions on the bastion. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal BastionActiveSessionListResult(IReadOnlyList<BastionActiveSession> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of active sessions on the bastion. </summary>
        public IReadOnlyList<BastionActiveSession> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
