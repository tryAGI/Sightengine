
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// A single detected face with attributes.
    /// </summary>
    public sealed partial class DetectedFace
    {
        /// <summary>
        /// Top-left X coordinate (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x1")]
        public double? X1 { get; set; }

        /// <summary>
        /// Top-left Y coordinate (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y1")]
        public double? Y1 { get; set; }

        /// <summary>
        /// Bottom-right X coordinate (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x2")]
        public double? X2 { get; set; }

        /// <summary>
        /// Bottom-right Y coordinate (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y2")]
        public double? Y2 { get; set; }

        /// <summary>
        /// Face feature attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Sightengine.DetectedFaceFeatures? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedFace" /> class.
        /// </summary>
        /// <param name="x1">
        /// Top-left X coordinate (0-1).
        /// </param>
        /// <param name="y1">
        /// Top-left Y coordinate (0-1).
        /// </param>
        /// <param name="x2">
        /// Bottom-right X coordinate (0-1).
        /// </param>
        /// <param name="y2">
        /// Bottom-right Y coordinate (0-1).
        /// </param>
        /// <param name="features">
        /// Face feature attributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectedFace(
            double? x1,
            double? y1,
            double? x2,
            double? y2,
            global::Sightengine.DetectedFaceFeatures? features)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedFace" /> class.
        /// </summary>
        public DetectedFace()
        {
        }
    }
}