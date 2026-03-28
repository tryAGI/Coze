#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatV3RequestPublishStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.ChatV3RequestPublishStatus>
    {
        /// <inheritdoc />
        public override global::Coze.ChatV3RequestPublishStatus Read(
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
                        return global::Coze.ChatV3RequestPublishStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.ChatV3RequestPublishStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.ChatV3RequestPublishStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.ChatV3RequestPublishStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Coze.ChatV3RequestPublishStatusExtensions.ToValueString(value));
        }
    }
}
