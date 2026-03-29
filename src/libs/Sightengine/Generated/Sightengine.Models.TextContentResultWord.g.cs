
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContentResultWord
    {
        /// <summary>
        /// The detected text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Type of content (profanity, email, phone, url, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentResultWord" /> class.
        /// </summary>
        /// <param name="text">
        /// The detected text.
        /// </param>
        /// <param name="type">
        /// Type of content (profanity, email, phone, url, etc.).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContentResultWord(
            string? text,
            string? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentResultWord" /> class.
        /// </summary>
        public TextContentResultWord()
        {
        }
    }
}