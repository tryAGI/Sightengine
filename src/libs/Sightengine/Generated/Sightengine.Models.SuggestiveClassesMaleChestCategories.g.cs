
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuggestiveClassesMaleChestCategories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("very_revealing")]
        public double? VeryRevealing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revealing")]
        public double? Revealing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slightly_revealing")]
        public double? SlightlyRevealing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("none")]
        public double? None { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestiveClassesMaleChestCategories" /> class.
        /// </summary>
        /// <param name="veryRevealing"></param>
        /// <param name="revealing"></param>
        /// <param name="slightlyRevealing"></param>
        /// <param name="none"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestiveClassesMaleChestCategories(
            double? veryRevealing,
            double? revealing,
            double? slightlyRevealing,
            double? none)
        {
            this.VeryRevealing = veryRevealing;
            this.Revealing = revealing;
            this.SlightlyRevealing = slightlyRevealing;
            this.None = none;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestiveClassesMaleChestCategories" /> class.
        /// </summary>
        public SuggestiveClassesMaleChestCategories()
        {
        }
    }
}