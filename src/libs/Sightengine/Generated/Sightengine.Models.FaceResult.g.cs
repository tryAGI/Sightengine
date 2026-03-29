
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Face detection and analysis results.
    /// </summary>
    public sealed partial class FaceResult
    {
        /// <summary>
        /// List of detected faces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faces")]
        public global::System.Collections.Generic.IList<global::Sightengine.DetectedFace>? Faces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceResult" /> class.
        /// </summary>
        /// <param name="faces">
        /// List of detected faces.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceResult(
            global::System.Collections.Generic.IList<global::Sightengine.DetectedFace>? faces)
        {
            this.Faces = faces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceResult" /> class.
        /// </summary>
        public FaceResult()
        {
        }
    }
}