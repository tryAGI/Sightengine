
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from the feedback API.
    /// </summary>
    public sealed partial class FeedbackResponse
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
        /// Feedback confirmation message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
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
        /// <param name="message">
        /// Feedback confirmation message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.MediaInfo? media,
            string? message)
        {
            this.Status = status;
            this.Request = request;
            this.Media = media;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        public FeedbackResponse()
        {
        }
    }
}