// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualWanVpnProfileParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (VpnServerConfigurationResourceId != null)
            {
                writer.WritePropertyName("vpnServerConfigurationResourceId");
                writer.WriteStringValue(VpnServerConfigurationResourceId);
            }
            if (AuthenticationMethod != null)
            {
                writer.WritePropertyName("authenticationMethod");
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
