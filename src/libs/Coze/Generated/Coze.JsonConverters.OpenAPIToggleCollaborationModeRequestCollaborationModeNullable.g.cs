#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAPIToggleCollaborationModeRequestCollaborationModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode?>
    {
        /// <inheritdoc />
        public override global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode? Read(
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
                        return global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
