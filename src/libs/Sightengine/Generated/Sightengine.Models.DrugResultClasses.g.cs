
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DrugResultClasses
    {
        /// <summary>
        /// Confidence score for recreational drugs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recreational")]
        public double? Recreational { get; set; }

        /// <summary>
        /// Confidence score for medical drugs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medical")]
        public double? Medical { get; set; }

        /// <summary>
        /// Confidence score for drug paraphernalia.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paraphernalia")]
        public double? Paraphernalia { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugResultClasses" /> class.
        /// </summary>
        /// <param name="recreational">
        /// Confidence score for recreational drugs.
        /// </param>
        /// <param name="medical">
        /// Confidence score for medical drugs.
        /// </param>
        /// <param name="paraphernalia">
        /// Confidence score for drug paraphernalia.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DrugResultClasses(
            double? recreational,
            double? medical,
            double? paraphernalia)
        {
            this.Recreational = recreational;
            this.Medical = medical;
            this.Paraphernalia = paraphernalia;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugResultClasses" /> class.
        /// </summary>
        public DrugResultClasses()
        {
        }
    }
}