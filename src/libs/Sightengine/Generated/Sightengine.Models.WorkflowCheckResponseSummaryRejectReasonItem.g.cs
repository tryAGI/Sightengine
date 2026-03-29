
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowCheckResponseSummaryRejectReasonItem
    {
        /// <summary>
        /// Rejection reason text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponseSummaryRejectReasonItem" /> class.
        /// </summary>
        /// <param name="text">
        /// Rejection reason text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowCheckResponseSummaryRejectReasonItem(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponseSummaryRejectReasonItem" /> class.
        /// </summary>
        public WorkflowCheckResponseSummaryRejectReasonItem()
        {
        }
    }
}