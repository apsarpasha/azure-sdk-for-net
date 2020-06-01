// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The action type of a rule collection. </summary>
    public readonly partial struct AzureFirewallRCActionType : IEquatable<AzureFirewallRCActionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AzureFirewallRCActionType"/> values are the same. </summary>
        public AzureFirewallRCActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static AzureFirewallRCActionType Allow { get; } = new AzureFirewallRCActionType(AllowValue);
        /// <summary> Deny. </summary>
        public static AzureFirewallRCActionType Deny { get; } = new AzureFirewallRCActionType(DenyValue);
        /// <summary> Determines if two <see cref="AzureFirewallRCActionType"/> values are the same. </summary>
        public static bool operator ==(AzureFirewallRCActionType left, AzureFirewallRCActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureFirewallRCActionType"/> values are not the same. </summary>
        public static bool operator !=(AzureFirewallRCActionType left, AzureFirewallRCActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureFirewallRCActionType"/>. </summary>
        public static implicit operator AzureFirewallRCActionType(string value) => new AzureFirewallRCActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureFirewallRCActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureFirewallRCActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
