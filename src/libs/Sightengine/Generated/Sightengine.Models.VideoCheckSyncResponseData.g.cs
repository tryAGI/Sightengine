
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Video analysis data.
    /// </summary>
    public sealed partial class VideoCheckSyncResponseData
    {
        /// <summary>
        /// Analyzed video frames.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<global::Sightengine.VideoFrame>? Frames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckSyncResponseData" /> class.
        /// </summary>
        /// <param name="frames">
        /// Analyzed video frames.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCheckSyncResponseData(
            global::System.Collections.Generic.IList<global::Sightengine.VideoFrame>? frames)
        {
            this.Frames = frames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCheckSyncResponseData" /> class.
        /// </summary>
        public VideoCheckSyncResponseData()
        {
        }
    }
}