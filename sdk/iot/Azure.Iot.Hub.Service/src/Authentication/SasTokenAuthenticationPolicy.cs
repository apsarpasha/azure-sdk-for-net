﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Iot.Hub.Service.Authentication
{
    internal class SasTokenAuthenticationPolicy : HttpPipelinePolicy
    {
        private readonly ISasTokenProvider _sasTokenProvider;

        public SasTokenAuthenticationPolicy(ISasTokenProvider sasTokenProvider)
        {
            _sasTokenProvider = sasTokenProvider;
        }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            AddHeaders(message);
            ProcessNext(message, pipeline);
        }

        public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            AddHeaders(message);
            await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
        }

        private void AddHeaders(HttpMessage message)
        {
            message.Request.Headers.Add(HttpHeader.Names.Authorization, _sasTokenProvider.GetSasToken());
        }
    }
}
