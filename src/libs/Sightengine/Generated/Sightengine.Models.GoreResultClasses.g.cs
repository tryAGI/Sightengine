
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoreResultClasses
    {
        /// <summary>
        /// Confidence score for very bloody content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("very_bloody")]
        public double? VeryBloody { get; set; }

        /// <summary>
        /// Confidence score for slightly bloody content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slightly_bloody")]
        public double? SlightlyBloody { get; set; }

        /// <summary>
        /// Confidence score for body organ content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_organ")]
        public double? BodyOrgan { get; set; }

        /// <summary>
        /// Confidence score for corpse content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpse")]
        public double? Corpse { get; set; }

        /// <summary>
        /// Confidence score for skull content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skull")]
        public double? Skull { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoreResultClasses" /> class.
        /// </summary>
        /// <param name="veryBloody">
        /// Confidence score for very bloody content.
        /// </param>
        /// <param name="slightlyBloody">
        /// Confidence score for slightly bloody content.
        /// </param>
        /// <param name="bodyOrgan">
        /// Confidence score for body organ content.
        /// </param>
        /// <param name="corpse">
        /// Confidence score for corpse content.
        /// </param>
        /// <param name="skull">
        /// Confidence score for skull content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoreResultClasses(
            double? veryBloody,
            double? slightlyBloody,
            double? bodyOrgan,
            double? corpse,
            double? skull)
        {
            this.VeryBloody = veryBloody;
            this.SlightlyBloody = slightlyBloody;
            this.BodyOrgan = bodyOrgan;
            this.Corpse = corpse;
            this.Skull = skull;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoreResultClasses" /> class.
        /// </summary>
        public GoreResultClasses()
        {
        }
    }
}