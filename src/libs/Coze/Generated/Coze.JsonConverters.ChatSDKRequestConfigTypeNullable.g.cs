#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatSDKRequestConfigTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.ChatSDKRequestConfigType?>
    {
        /// <inheritdoc />
        public override global::Coze.ChatSDKRequestConfigType? Read(
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
                        return global::Coze.ChatSDKRequestConfigTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.ChatSDKRequestConfigType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.ChatSDKRequestConfigType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.ChatSDKRequestConfigType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Coze.ChatSDKRequestConfigTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
