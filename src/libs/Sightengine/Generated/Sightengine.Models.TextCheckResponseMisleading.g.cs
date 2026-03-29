
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Misleading content detection (for username mode).
    /// </summary>
    public sealed partial class TextCheckResponseMisleading
    {
        /// <summary>
        /// Probability of misleading content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prob")]
        public double? Prob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseMisleading" /> class.
        /// </summary>
        /// <param name="prob">
        /// Probability of misleading content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCheckResponseMisleading(
            double? prob)
        {
            this.Prob = prob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseMisleading" /> class.
        /// </summary>
        public TextCheckResponseMisleading()
        {
        }
    }
}