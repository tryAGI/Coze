#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDocumentOpenAPIAgwJsConvNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.CreateDocumentOpenAPIAgwJsConv?>
    {
        /// <inheritdoc />
        public override global::Coze.CreateDocumentOpenAPIAgwJsConv? Read(
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
                        return global::Coze.CreateDocumentOpenAPIAgwJsConvExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.CreateDocumentOpenAPIAgwJsConv)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.CreateDocumentOpenAPIAgwJsConv?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.CreateDocumentOpenAPIAgwJsConv? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Coze.CreateDocumentOpenAPIAgwJsConvExtensions.ToValueString(value.Value));
            }
        }
    }
}
