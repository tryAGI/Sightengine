
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Image quality assessment results.
    /// </summary>
    public sealed partial class ImageQualityResult
    {
        /// <summary>
        /// Overall quality score (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Whether the image is blurry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blurry")]
        public bool? IsBlurry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageQualityResult" /> class.
        /// </summary>
        /// <param name="quality">
        /// Overall quality score (0-1).
        /// </param>
        /// <param name="isBlurry">
        /// Whether the image is blurry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageQualityResult(
            double? quality,
            bool? isBlurry)
        {
            this.Quality = quality;
            this.IsBlurry = isBlurry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageQualityResult" /> class.
        /// </summary>
        public ImageQualityResult()
        {
        }
    }
}