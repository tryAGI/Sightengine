
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from text moderation check.
    /// </summary>
    public sealed partial class TextCheckResponse
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
        /// Profanity detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public global::Sightengine.TextCheckResponseProfanity? Profanity { get; set; }

        /// <summary>
        /// Personal information detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personal")]
        public global::Sightengine.TextCheckResponsePersonal? Personal { get; set; }

        /// <summary>
        /// Link detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public global::Sightengine.TextCheckResponseLink? Link { get; set; }

        /// <summary>
        /// Misleading content detection (for username mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misleading")]
        public global::Sightengine.TextCheckResponseMisleading? Misleading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Response status.
        /// </param>
        /// <param name="request">
        /// Information about the API request.
        /// </param>
        /// <param name="profanity">
        /// Profanity detection results.
        /// </param>
        /// <param name="personal">
        /// Personal information detection results.
        /// </param>
        /// <param name="link">
        /// Link detection results.
        /// </param>
        /// <param name="misleading">
        /// Misleading content detection (for username mode).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCheckResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.TextCheckResponseProfanity? profanity,
            global::Sightengine.TextCheckResponsePersonal? personal,
            global::Sightengine.TextCheckResponseLink? link,
            global::Sightengine.TextCheckResponseMisleading? misleading)
        {
            this.Status = status;
            this.Request = request;
            this.Profanity = profanity;
            this.Personal = personal;
            this.Link = link;
            this.Misleading = misleading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponse" /> class.
        /// </summary>
        public TextCheckResponse()
        {
        }
    }
}