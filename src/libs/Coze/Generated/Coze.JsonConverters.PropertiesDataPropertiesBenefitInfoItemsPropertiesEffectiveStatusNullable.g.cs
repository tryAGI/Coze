#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus?>
    {
        /// <inheritdoc />
        public override global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus? Read(
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
                        return global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
