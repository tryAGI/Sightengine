
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from asynchronous video moderation initiation.
    /// </summary>
    public sealed partial class VideoCheckAsyncResponse
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
        /// Registered callback URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckAsyncResponse" /> class.
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
        /// <param name="callback">
        /// Registered callback URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCheckAsyncResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.MediaInfo? media,
            string? callback)
        {
            this.Status = status;
            this.Request = request;
            this.Media = media;
            this.Callback = callback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckAsyncResponse" /> class.
        /// </summary>
        public VideoCheckAsyncResponse()
        {
        }
    }
}