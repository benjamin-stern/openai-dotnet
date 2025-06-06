// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;
using OpenAI.Internal;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(InternalWebSearchLocation approximate)
        {
            Argument.AssertNotNull(approximate, nameof(approximate));

            Approximate = approximate;
        }

        internal InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1Type @type, InternalWebSearchLocation approximate, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Type = @type;
            Approximate = approximate;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1Type Type { get; } = "approximate";

        public InternalWebSearchLocation Approximate { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
