
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckImageByUploadRequest
    {
        /// <summary>
        /// The image file to analyze.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Media { get; set; }

        /// <summary>
        /// The image file to analyze.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Medianame { get; set; }

        /// <summary>
        /// Comma-separated list of detection models to apply.<br/>
        /// Available models: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, face-attributes, text-content,<br/>
        /// qr-content, genai, type, quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckImageByUploadRequest" /> class.
        /// </summary>
        /// <param name="media">
        /// The image file to analyze.
        /// </param>
        /// <param name="medianame">
        /// The image file to analyze.
        /// </param>
        /// <param name="models">
        /// Comma-separated list of detection models to apply.<br/>
        /// Available models: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, face-attributes, text-content,<br/>
        /// qr-content, genai, type, quality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckImageByUploadRequest(
            byte[] media,
            string medianame,
            string models)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Medianame = medianame ?? throw new global::System.ArgumentNullException(nameof(medianame));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckImageByUploadRequest" /> class.
        /// </summary>
        public CheckImageByUploadRequest()
        {
        }
    }
}