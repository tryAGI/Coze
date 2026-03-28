#nullable enable

namespace Coze.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsBenefitTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType>
    {
        /// <inheritdoc />
        public override global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType Read(
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
                        return global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeExtensions.ToValueString(value));
        }
    }
}
