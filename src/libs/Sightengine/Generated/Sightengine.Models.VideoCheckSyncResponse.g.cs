
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from synchronous video moderation.
    /// </summary>
    public sealed partial class VideoCheckSyncResponse
    {
        /// <summary>
        /// Response status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Information about the API request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Sightengine.RequestInfo? Request { get; set; }

        /// <summary>
        /// Information about the analyzed media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::Sightengine.MediaInfo? Media { get; set; }

        /// <summary>
        /// Video analysis data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Sightengine.VideoCheckSyncResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckSyncResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Response status.
        /// </param>
        /// <param name="request">
        /// Information about the API request.
        /// </param>
        /// <param name="media">
        /// Information about the analyzed media.
        /// </param>
        /// <param name="data">
        /// Video analysis data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCheckSyncResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.MediaInfo? media,
            global::Sightengine.VideoCheckSyncResponseData? data)
        {
            this.Status = status;
            this.Request = request;
            this.Media = media;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckSyncResponse" /> class.
        /// </summary>
        public VideoCheckSyncResponse()
        {
        }
    }
}