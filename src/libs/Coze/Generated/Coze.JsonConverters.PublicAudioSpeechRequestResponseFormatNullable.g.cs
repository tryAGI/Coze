#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicAudioSpeechRequestResponseFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.PublicAudioSpeechRequestResponseFormat?>
    {
        /// <inheritdoc />
        public override global::Coze.PublicAudioSpeechRequestResponseFormat? Read(
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
                        return global::Coze.PublicAudioSpeechRequestResponseFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.PublicAudioSpeechRequestResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.PublicAudioSpeechRequestResponseFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.PublicAudioSpeechRequestResponseFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Coze.PublicAudioSpeechRequestResponseFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
