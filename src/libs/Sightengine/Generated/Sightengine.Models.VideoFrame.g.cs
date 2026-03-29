
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// A single analyzed video frame.
    /// </summary>
    public sealed partial class VideoFrame
    {
        /// <summary>
        /// Frame information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public global::Sightengine.VideoFrameInfo? Info { get; set; }

        /// <summary>
        /// Nudity detection results with confidence scores (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nudity")]
        public global::Sightengine.NudityResult? Nudity { get; set; }

        /// <summary>
        /// Weapon detection score for this frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weapon")]
        public double? Weapon { get; set; }

        /// <summary>
        /// Alcohol detection score for this frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alcohol")]
        public double? Alcohol { get; set; }

        /// <summary>
        /// Drug detection score for this frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drugs")]
        public double? Drugs { get; set; }

        /// <summary>
        /// Offensive content detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offensive")]
        public global::Sightengine.OffensiveResult? Offensive { get; set; }

        /// <summary>
        /// Gore and disturbing content detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gore")]
        public global::Sightengine.GoreResult? Gore { get; set; }

        /// <summary>
        /// Violence detection score for this frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public double? Violence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrame" /> class.
        /// </summary>
        /// <param name="info">
        /// Frame information.
        /// </param>
        /// <param name="nudity">
        /// Nudity detection results with confidence scores (0-1).
        /// </param>
        /// <param name="weapon">
        /// Weapon detection score for this frame.
        /// </param>
        /// <param name="alcohol">
        /// Alcohol detection score for this frame.
        /// </param>
        /// <param name="drugs">
        /// Drug detection score for this frame.
        /// </param>
        /// <param name="offensive">
        /// Offensive content detection results.
        /// </param>
        /// <param name="gore">
        /// Gore and disturbing content detection results.
        /// </param>
        /// <param name="violence">
        /// Violence detection score for this frame.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFrame(
            global::Sightengine.VideoFrameInfo? info,
            global::Sightengine.NudityResult? nudity,
            double? weapon,
            double? alcohol,
            double? drugs,
            global::Sightengine.OffensiveResult? offensive,
            global::Sightengine.GoreResult? gore,
            double? violence)
        {
            this.Info = info;
            this.Nudity = nudity;
            this.Weapon = weapon;
            this.Alcohol = alcohol;
            this.Drugs = drugs;
            this.Offensive = offensive;
            this.Gore = gore;
            this.Violence = violence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrame" /> class.
        /// </summary>
        public VideoFrame()
        {
        }
    }
}