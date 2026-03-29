
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Information about the analyzed media.
    /// </summary>
    public sealed partial class MediaInfo
    {
        /// <summary>
        /// Unique media identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URI of the analyzed media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique media identifier.
        /// </param>
        /// <param name="uri">
        /// URI of the analyzed media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaInfo(
            string? id,
            string? uri)
        {
            this.Id = id;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaInfo" /> class.
        /// </summary>
        public MediaInfo()
        {
        }
    }
}