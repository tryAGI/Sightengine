
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// A link match in text.
    /// </summary>
    public sealed partial class LinkMatch
    {
        /// <summary>
        /// Type of link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The matched link text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public string? Match { get; set; }

        /// <summary>
        /// Start character index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// End character index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public int? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkMatch" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of link.
        /// </param>
        /// <param name="match">
        /// The matched link text.
        /// </param>
        /// <param name="start">
        /// Start character index.
        /// </param>
        /// <param name="end">
        /// End character index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkMatch(
            string? type,
            string? match,
            int? start,
            int? end)
        {
            this.Type = type;
            this.Match = match;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkMatch" /> class.
        /// </summary>
        public LinkMatch()
        {
        }
    }
}