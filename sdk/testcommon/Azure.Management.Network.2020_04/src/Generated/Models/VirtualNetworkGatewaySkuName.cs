// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Gateway SKU name. </summary>
    public readonly partial struct VirtualNetworkGatewaySkuName : IEquatable<VirtualNetworkGatewaySkuName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuName"/> values are the same. </summary>
        public VirtualNetworkGatewaySkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string HighPerformanceValue = "HighPerformance";
        private const string StandardValue = "Standard";
        private const string UltraPerformanceValue = "UltraPerformance";
        private const string VpnGw1Value = "VpnGw1";
        private const string VpnGw2Value = "VpnGw2";
        private const string VpnGw3Value = "VpnGw3";
        private const string VpnGw4Value = "VpnGw4";
        private const string VpnGw5Value = "VpnGw5";
        private const string VpnGw1AZValue = "VpnGw1AZ";
        private const string VpnGw2AZValue = "VpnGw2AZ";
        private const string VpnGw3AZValue = "VpnGw3AZ";
        private const string VpnGw4AZValue = "VpnGw4AZ";
        private const string VpnGw5AZValue = "VpnGw5AZ";
        private const string ErGw1AZValue = "ErGw1AZ";
        private const string ErGw2AZValue = "ErGw2AZ";
        private const string ErGw3AZValue = "ErGw3AZ";

        /// <summary> Basic. </summary>
        public static VirtualNetworkGatewaySkuName Basic { get; } = new VirtualNetworkGatewaySkuName(BasicValue);
        /// <summary> HighPerformance. </summary>
        public static VirtualNetworkGatewaySkuName HighPerformance { get; } = new VirtualNetworkGatewaySkuName(HighPerformanceValue);
        /// <summary> Standard. </summary>
        public static VirtualNetworkGatewaySkuName Standard { get; } = new VirtualNetworkGatewaySkuName(StandardValue);
        /// <summary> UltraPerformance. </summary>
        public static VirtualNetworkGatewaySkuName UltraPerformance { get; } = new VirtualNetworkGatewaySkuName(UltraPerformanceValue);
        /// <summary> VpnGw1. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw1 { get; } = new VirtualNetworkGatewaySkuName(VpnGw1Value);
        /// <summary> VpnGw2. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw2 { get; } = new VirtualNetworkGatewaySkuName(VpnGw2Value);
        /// <summary> VpnGw3. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw3 { get; } = new VirtualNetworkGatewaySkuName(VpnGw3Value);
        /// <summary> VpnGw4. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw4 { get; } = new VirtualNetworkGatewaySkuName(VpnGw4Value);
        /// <summary> VpnGw5. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw5 { get; } = new VirtualNetworkGatewaySkuName(VpnGw5Value);
        /// <summary> VpnGw1AZ. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw1AZ { get; } = new VirtualNetworkGatewaySkuName(VpnGw1AZValue);
        /// <summary> VpnGw2AZ. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw2AZ { get; } = new VirtualNetworkGatewaySkuName(VpnGw2AZValue);
        /// <summary> VpnGw3AZ. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw3AZ { get; } = new VirtualNetworkGatewaySkuName(VpnGw3AZValue);
        /// <summary> VpnGw4AZ. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw4AZ { get; } = new VirtualNetworkGatewaySkuName(VpnGw4AZValue);
        /// <summary> VpnGw5AZ. </summary>
        public static VirtualNetworkGatewaySkuName VpnGw5AZ { get; } = new VirtualNetworkGatewaySkuName(VpnGw5AZValue);
        /// <summary> ErGw1AZ. </summary>
        public static VirtualNetworkGatewaySkuName ErGw1AZ { get; } = new VirtualNetworkGatewaySkuName(ErGw1AZValue);
        /// <summary> ErGw2AZ. </summary>
        public static VirtualNetworkGatewaySkuName ErGw2AZ { get; } = new VirtualNetworkGatewaySkuName(ErGw2AZValue);
        /// <summary> ErGw3AZ. </summary>
        public static VirtualNetworkGatewaySkuName ErGw3AZ { get; } = new VirtualNetworkGatewaySkuName(ErGw3AZValue);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuName"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkGatewaySkuName left, VirtualNetworkGatewaySkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuName"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkGatewaySkuName left, VirtualNetworkGatewaySkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkGatewaySkuName"/>. </summary>
        public static implicit operator VirtualNetworkGatewaySkuName(string value) => new VirtualNetworkGatewaySkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkGatewaySkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkGatewaySkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
