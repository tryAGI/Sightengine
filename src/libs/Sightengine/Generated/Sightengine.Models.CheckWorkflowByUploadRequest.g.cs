
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckWorkflowByUploadRequest
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
        /// Workflow ID from the Sightengine dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowByUploadRequest" /> class.
        /// </summary>
        /// <param name="media">
        /// The image file to analyze.
        /// </param>
        /// <param name="medianame">
        /// The image file to analyze.
        /// </param>
        /// <param name="workflow">
        /// Workflow ID from the Sightengine dashboard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckWorkflowByUploadRequest(
            byte[] media,
            string medianame,
            string workflow)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Medianame = medianame ?? throw new global::System.ArgumentNullException(nameof(medianame));
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowByUploadRequest" /> class.
        /// </summary>
        public CheckWorkflowByUploadRequest()
        {
        }
    }
}