
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from the workflow-based moderation check.
    /// </summary>
    public sealed partial class WorkflowCheckResponse
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
        /// Workflow moderation summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Sightengine.WorkflowCheckResponseSummary? Summary { get; set; }

        /// <summary>
        /// Workflow information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Sightengine.WorkflowCheckResponseWorkflow? Workflow { get; set; }

        /// <summary>
        /// Information about the analyzed media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::Sightengine.MediaInfo? Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Response status.
        /// </param>
        /// <param name="request">
        /// Information about the API request.
        /// </param>
        /// <param name="summary">
        /// Workflow moderation summary.
        /// </param>
        /// <param name="workflow">
        /// Workflow information.
        /// </param>
        /// <param name="media">
        /// Information about the analyzed media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowCheckResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.WorkflowCheckResponseSummary? summary,
            global::Sightengine.WorkflowCheckResponseWorkflow? workflow,
            global::Sightengine.MediaInfo? media)
        {
            this.Status = status;
            this.Request = request;
            this.Summary = summary;
            this.Workflow = workflow;
            this.Media = media;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponse" /> class.
        /// </summary>
        public WorkflowCheckResponse()
        {
        }
    }
}