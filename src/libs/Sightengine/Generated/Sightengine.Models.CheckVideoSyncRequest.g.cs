
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckVideoSyncRequest
    {
        /// <summary>
        /// The video file to analyze (use this OR stream_url).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public byte[]? Media { get; set; }

        /// <summary>
        /// The video file to analyze (use this OR stream_url).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        public string? Medianame { get; set; }

        /// <summary>
        /// Public URL of the video (use this OR media).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_url")]
        public string? StreamUrl { get; set; }

        /// <summary>
        /// Comma-separated list of detection models.<br/>
        /// Available: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam.
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
        /// Initializes a new instance of the <see cref="CheckVideoSyncRequest" /> class.
        /// </summary>
        /// <param name="models">
        /// Comma-separated list of detection models.<br/>
        /// Available: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam.
        /// </param>
        /// <param name="media">
        /// The video file to analyze (use this OR stream_url).
        /// </param>
        /// <param name="medianame">
        /// The video file to analyze (use this OR stream_url).
        /// </param>
        /// <param name="streamUrl">
        /// Public URL of the video (use this OR media).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckVideoSyncRequest(
            string models,
            byte[]? media,
            string? medianame,
            string? streamUrl)
        {
            this.Media = media;
            this.Medianame = medianame;
            this.StreamUrl = streamUrl;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckVideoSyncRequest" /> class.
        /// </summary>
        public CheckVideoSyncRequest()
        {
        }
    }
}