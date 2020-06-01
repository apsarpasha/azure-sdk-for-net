// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.DigitalTwins.Core.Models
{
    /// <summary> A collection of EventRoute objects. </summary>
    internal partial class EventRouteCollection
    {
        /// <summary> Initializes a new instance of EventRouteCollection. </summary>
        internal EventRouteCollection()
        {
        }

        /// <summary> Initializes a new instance of EventRouteCollection. </summary>
        /// <param name="value"> The EventRoute objects. </param>
        /// <param name="nextLink"> A URI to retrieve the next page of results. </param>
        internal EventRouteCollection(IReadOnlyList<EventRoute> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The EventRoute objects. </summary>
        public IReadOnlyList<EventRoute> Value { get; }
        /// <summary> A URI to retrieve the next page of results. </summary>
        public string NextLink { get; }
    }
}
