
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitFeedbackRequest
    {
        /// <summary>
        /// Public URL to the image (use this OR media).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The image file (use this OR url).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public byte[]? Media { get; set; }

        /// <summary>
        /// The image file (use this OR url).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        public string? Medianame { get; set; }

        /// <summary>
        /// The model that classified the image.<br/>
        /// Available: nudity, gore, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, genai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The expected/correct classification result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that classified the image.<br/>
        /// Available: nudity, gore, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, genai.
        /// </param>
        /// <param name="class">
        /// The expected/correct classification result.
        /// </param>
        /// <param name="url">
        /// Public URL to the image (use this OR media).
        /// </param>
        /// <param name="media">
        /// The image file (use this OR url).
        /// </param>
        /// <param name="medianame">
        /// The image file (use this OR url).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitFeedbackRequest(
            string model,
            string @class,
            string? url,
            byte[]? media,
            string? medianame)
        {
            this.Url = url;
            this.Media = media;
            this.Medianame = medianame;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        public SubmitFeedbackRequest()
        {
        }
    }
}