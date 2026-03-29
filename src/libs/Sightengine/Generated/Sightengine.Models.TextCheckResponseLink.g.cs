
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Link detection results.
    /// </summary>
    public sealed partial class TextCheckResponseLink
    {
        /// <summary>
        /// List of link matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::Sightengine.LinkMatch>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseLink" /> class.
        /// </summary>
        /// <param name="matches">
        /// List of link matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCheckResponseLink(
            global::System.Collections.Generic.IList<global::Sightengine.LinkMatch>? matches)
        {
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponseLink" /> class.
        /// </summary>
        public TextCheckResponseLink()
        {
        }
    }
}