#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus>
    {
        /// <inheritdoc />
        public override global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus Read(
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
                        return global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusExtensions.ToValueString(value));
        }
    }
}
