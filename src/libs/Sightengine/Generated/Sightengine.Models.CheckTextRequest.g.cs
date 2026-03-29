
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckTextRequest
    {
        /// <summary>
        /// UTF-8 formatted text to moderate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// ISO 639-1 language code (e.g., en, fr, de).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; }

        /// <summary>
        /// Moderation mode (rules or username).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sightengine.JsonConverters.CheckTextRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Sightengine.CheckTextRequestMode Mode { get; set; }

        /// <summary>
        /// Comma-separated country codes for phone number detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opt_countries")]
        public string? OptCountries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckTextRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// UTF-8 formatted text to moderate.
        /// </param>
        /// <param name="lang">
        /// ISO 639-1 language code (e.g., en, fr, de).
        /// </param>
        /// <param name="mode">
        /// Moderation mode (rules or username).
        /// </param>
        /// <param name="optCountries">
        /// Comma-separated country codes for phone number detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckTextRequest(
            string text,
            string lang,
            global::Sightengine.CheckTextRequestMode mode,
            string? optCountries)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.Mode = mode;
            this.OptCountries = optCountries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckTextRequest" /> class.
        /// </summary>
        public CheckTextRequest()
        {
        }
    }
}