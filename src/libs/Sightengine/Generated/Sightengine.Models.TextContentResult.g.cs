
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Text detected in image via OCR.
    /// </summary>
    public sealed partial class TextContentResult
    {
        /// <summary>
        /// List of detected text elements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Sightengine.TextContentResultWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentResult" /> class.
        /// </summary>
        /// <param name="words">
        /// List of detected text elements.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContentResult(
            global::System.Collections.Generic.IList<global::Sightengine.TextContentResultWord>? words)
        {
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentResult" /> class.
        /// </summary>
        public TextContentResult()
        {
        }
    }
}