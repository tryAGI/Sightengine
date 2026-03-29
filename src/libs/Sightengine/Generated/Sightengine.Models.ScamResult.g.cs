
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Scam and fraud detection results.
    /// </summary>
    public sealed partial class ScamResult
    {
        /// <summary>
        /// Probability of scam/fraud content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prob")]
        public double? Prob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScamResult" /> class.
        /// </summary>
        /// <param name="prob">
        /// Probability of scam/fraud content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScamResult(
            double? prob)
        {
            this.Prob = prob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScamResult" /> class.
        /// </summary>
        public ScamResult()
        {
        }
    }
}