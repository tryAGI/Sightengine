
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Personal information detection results.
    /// </summary>
    public sealed partial class TextCheckResponsePersonal
    {
        /// <summary>
        /// List of personal info matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::Sightengine.PersonalMatch>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponsePersonal" /> class.
        /// </summary>
        /// <param name="matches">
        /// List of personal info matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCheckResponsePersonal(
            global::System.Collections.Generic.IList<global::Sightengine.PersonalMatch>? matches)
        {
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCheckResponsePersonal" /> class.
        /// </summary>
        public TextCheckResponsePersonal()
        {
        }
    }
}