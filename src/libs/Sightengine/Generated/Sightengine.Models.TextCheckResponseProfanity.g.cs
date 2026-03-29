
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Profanity detection results.
    /// </summary>
    public sealed partial class TextCheckResponseProfanity
    {
        /// <summary>
        /// List of profanity matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::Sightengine.ProfanityMatch>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseProfanity" /> class.
        /// </summary>
        /// <param name="matches">
        /// List of profanity matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCheckResponseProfanity(
            global::System.Collections.Generic.IList<global::Sightengine.ProfanityMatch>? matches)
        {
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseProfanity" /> class.
        /// </summary>
        public TextCheckResponseProfanity()
        {
        }
    }
}