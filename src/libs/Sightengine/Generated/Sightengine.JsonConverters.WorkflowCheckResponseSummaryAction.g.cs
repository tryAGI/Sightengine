#nullable enable

namespace Sightengine.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowCheckResponseSummaryActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Sightengine.WorkflowCheckResponseSummaryAction>
    {
        /// <inheritdoc />
        public override global::Sightengine.WorkflowCheckResponseSummaryAction Read(
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
                        return global::Sightengine.WorkflowCheckResponseSummaryActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Sightengine.WorkflowCheckResponseSummaryAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Sightengine.WorkflowCheckResponseSummaryAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Sightengine.WorkflowCheckResponseSummaryAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Sightengine.WorkflowCheckResponseSummaryActionExtensions.ToValueString(value));
        }
    }
}
