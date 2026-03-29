
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Workflow moderation summary.
    /// </summary>
    public sealed partial class WorkflowCheckResponseSummary
    {
        /// <summary>
        /// Recommended action (accept or reject).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sightengine.JsonConverters.WorkflowCheckResponseSummaryActionJsonConverter))]
        public global::Sightengine.WorkflowCheckResponseSummaryAction? Action { get; set; }

        /// <summary>
        /// Probability of rejection (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject_prob")]
        public double? RejectProb { get; set; }

        /// <summary>
        /// Reasons for rejection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public global::System.Collections.Generic.IList<global::Sightengine.WorkflowCheckResponseSummaryRejectReasonItem>? RejectReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponseSummary" /> class.
        /// </summary>
        /// <param name="action">
        /// Recommended action (accept or reject).
        /// </param>
        /// <param name="rejectProb">
        /// Probability of rejection (0-1).
        /// </param>
        /// <param name="rejectReason">
        /// Reasons for rejection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowCheckResponseSummary(
            global::Sightengine.WorkflowCheckResponseSummaryAction? action,
            double? rejectProb,
            global::System.Collections.Generic.IList<global::Sightengine.WorkflowCheckResponseSummaryRejectReasonItem>? rejectReason)
        {
            this.Action = action;
            this.RejectProb = rejectProb;
            this.RejectReason = rejectReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCheckResponseSummary" /> class.
        /// </summary>
        public WorkflowCheckResponseSummary()
        {
        }
    }
}