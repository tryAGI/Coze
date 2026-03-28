#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenListBotVersionsPublishStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.OpenListBotVersionsPublishStatus>
    {
        /// <inheritdoc />
        public override global::Coze.OpenListBotVersionsPublishStatus Read(
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
                        return global::Coze.OpenListBotVersionsPublishStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.OpenListBotVersionsPublishStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.OpenListBotVersionsPublishStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.OpenListBotVersionsPublishStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Coze.OpenListBotVersionsPublishStatusExtensions.ToValueString(value));
        }
    }
}
