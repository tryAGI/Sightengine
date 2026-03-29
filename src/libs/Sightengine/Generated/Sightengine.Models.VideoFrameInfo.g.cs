
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Frame information.
    /// </summary>
    public sealed partial class VideoFrameInfo
    {
        /// <summary>
        /// Frame identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Frame position in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public double? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrameInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Frame identifier.
        /// </param>
        /// <param name="position">
        /// Frame position in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFrameInfo(
            string? id,
            double? position)
        {
            this.Id = id;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrameInfo" /> class.
        /// </summary>
        public VideoFrameInfo()
        {
        }
    }
}