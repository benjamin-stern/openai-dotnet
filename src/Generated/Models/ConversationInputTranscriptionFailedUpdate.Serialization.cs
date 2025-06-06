// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationInputTranscriptionFailedUpdate : IJsonModel<ConversationInputTranscriptionFailedUpdate>
    {
        internal ConversationInputTranscriptionFailedUpdate()
        {
        }

        void IJsonModel<ConversationInputTranscriptionFailedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputTranscriptionFailedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputTranscriptionFailedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("content_index") != true)
            {
                writer.WritePropertyName("content_index"u8);
                writer.WriteNumberValue(ContentIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("error") != true)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(_error, options);
            }
        }

        ConversationInputTranscriptionFailedUpdate IJsonModel<ConversationInputTranscriptionFailedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationInputTranscriptionFailedUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputTranscriptionFailedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputTranscriptionFailedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationInputTranscriptionFailedUpdate(document.RootElement, options);
        }

        internal static ConversationInputTranscriptionFailedUpdate DeserializeConversationInputTranscriptionFailedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventId = default;
            ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string itemId = default;
            int contentIndex = default;
            InternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError error = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("content_index"u8))
                {
                    contentIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("error"u8))
                {
                    error = InternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError.DeserializeInternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ConversationInputTranscriptionFailedUpdate(
                eventId,
                kind,
                additionalBinaryDataProperties,
                itemId,
                contentIndex,
                error);
        }

        BinaryData IPersistableModel<ConversationInputTranscriptionFailedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputTranscriptionFailedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationInputTranscriptionFailedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationInputTranscriptionFailedUpdate IPersistableModel<ConversationInputTranscriptionFailedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationInputTranscriptionFailedUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputTranscriptionFailedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationInputTranscriptionFailedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationInputTranscriptionFailedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationInputTranscriptionFailedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationInputTranscriptionFailedUpdate conversationInputTranscriptionFailedUpdate)
        {
            if (conversationInputTranscriptionFailedUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(conversationInputTranscriptionFailedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationInputTranscriptionFailedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationInputTranscriptionFailedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
