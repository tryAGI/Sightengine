
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Image type classification result.
    /// </summary>
    public sealed partial class ImageTypeResult
    {
        /// <summary>
        /// Confidence the image is a photograph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo")]
        public double? Photo { get; set; }

        /// <summary>
        /// Confidence the image is an illustration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illustration")]
        public double? Illustration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTypeResult" /> class.
        /// </summary>
        /// <param name="photo">
        /// Confidence the image is a photograph.
        /// </param>
        /// <param name="illustration">
        /// Confidence the image is an illustration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTypeResult(
            double? photo,
            double? illustration)
        {
            this.Photo = photo;
            this.Illustration = illustration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTypeResult" /> class.
        /// </summary>
        public ImageTypeResult()
        {
        }
    }
}