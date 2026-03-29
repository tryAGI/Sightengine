
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// AI-generated content detection result.
    /// </summary>
    public sealed partial class AiGeneratedResult
    {
        /// <summary>
        /// Confidence score that the image was AI-generated (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_generated")]
        public double? AiGenerated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGeneratedResult" /> class.
        /// </summary>
        /// <param name="aiGenerated">
        /// Confidence score that the image was AI-generated (0-1).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGeneratedResult(
            double? aiGenerated)
        {
            this.AiGenerated = aiGenerated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGeneratedResult" /> class.
        /// </summary>
        public AiGeneratedResult()
        {
        }
    }
}