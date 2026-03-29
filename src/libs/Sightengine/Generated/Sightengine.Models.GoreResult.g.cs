
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Gore and disturbing content detection results.
    /// </summary>
    public sealed partial class GoreResult
    {
        /// <summary>
        /// Overall probability of gore content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prob")]
        public double? Prob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::Sightengine.GoreResultClasses? Classes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoreResult" /> class.
        /// </summary>
        /// <param name="prob">
        /// Overall probability of gore content.
        /// </param>
        /// <param name="classes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoreResult(
            double? prob,
            global::Sightengine.GoreResultClasses? classes)
        {
            this.Prob = prob;
            this.Classes = classes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoreResult" /> class.
        /// </summary>
        public GoreResult()
        {
        }
    }
}