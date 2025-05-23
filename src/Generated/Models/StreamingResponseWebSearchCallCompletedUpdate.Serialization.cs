// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class StreamingResponseWebSearchCallCompletedUpdate : IJsonModel<StreamingResponseWebSearchCallCompletedUpdate>
    {
        internal StreamingResponseWebSearchCallCompletedUpdate()
        {
        }

        void IJsonModel<StreamingResponseWebSearchCallCompletedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseWebSearchCallCompletedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
        }

        StreamingResponseWebSearchCallCompletedUpdate IJsonModel<StreamingResponseWebSearchCallCompletedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (StreamingResponseWebSearchCallCompletedUpdate)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseWebSearchCallCompletedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingResponseWebSearchCallCompletedUpdate(document.RootElement, options);
        }

        internal static StreamingResponseWebSearchCallCompletedUpdate DeserializeStreamingResponseWebSearchCallCompletedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesResponseStreamEventType @type = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string itemId = default;
            int outputIndex = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesResponseStreamEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new StreamingResponseWebSearchCallCompletedUpdate(@type, additionalBinaryDataProperties, itemId, outputIndex);
        }

        BinaryData IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseWebSearchCallCompletedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingResponseWebSearchCallCompletedUpdate IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (StreamingResponseWebSearchCallCompletedUpdate)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeStreamingResponseWebSearchCallCompletedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseWebSearchCallCompletedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingResponseWebSearchCallCompletedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(StreamingResponseWebSearchCallCompletedUpdate streamingResponseWebSearchCallCompletedUpdate)
        {
            if (streamingResponseWebSearchCallCompletedUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(streamingResponseWebSearchCallCompletedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator StreamingResponseWebSearchCallCompletedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeStreamingResponseWebSearchCallCompletedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
