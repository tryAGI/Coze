#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubmitToolOutputsResponseEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.SubmitToolOutputsResponseEvent>
    {
        /// <inheritdoc />
        public override global::Coze.SubmitToolOutputsResponseEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Coze.SubmitToolOutputsResponseEventExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.SubmitToolOutputsResponseEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.SubmitToolOutputsResponseEvent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.SubmitToolOutputsResponseEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Coze.SubmitToolOutputsResponseEventExtensions.ToValueString(value));
        }
    }
}
