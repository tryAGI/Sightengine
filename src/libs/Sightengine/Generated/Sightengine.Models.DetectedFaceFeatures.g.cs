
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Face feature attributes.
    /// </summary>
    public sealed partial class DetectedFaceFeatures
    {
        /// <summary>
        /// Detected gender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Confidence the person is a minor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor")]
        public double? Minor { get; set; }

        /// <summary>
        /// Estimated age.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public double? Age { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedFaceFeatures" /> class.
        /// </summary>
        /// <param name="gender">
        /// Detected gender.
        /// </param>
        /// <param name="minor">
        /// Confidence the person is a minor.
        /// </param>
        /// <param name="age">
        /// Estimated age.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectedFaceFeatures(
            string? gender,
            double? minor,
            double? age)
        {
            this.Gender = gender;
            this.Minor = minor;
            this.Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedFaceFeatures" /> class.
        /// </summary>
        public DetectedFaceFeatures()
        {
        }
    }
}