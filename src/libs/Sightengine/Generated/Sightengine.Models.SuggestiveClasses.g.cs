
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Breakdown of suggestive content categories.
    /// </summary>
    public sealed partial class SuggestiveClasses
    {
        /// <summary>
        /// Confidence score for bikini content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bikini")]
        public double? Bikini { get; set; }

        /// <summary>
        /// Confidence score for cleavage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleavage")]
        public double? Cleavage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleavage_categories")]
        public global::Sightengine.SuggestiveClassesCleavageCategories? CleavageCategories { get; set; }

        /// <summary>
        /// Confidence score for lingerie.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lingerie")]
        public double? Lingerie { get; set; }

        /// <summary>
        /// Confidence score for male chest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("male_chest")]
        public double? MaleChest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("male_chest_categories")]
        public global::Sightengine.SuggestiveClassesMaleChestCategories? MaleChestCategories { get; set; }

        /// <summary>
        /// Confidence score for male underwear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("male_underwear")]
        public double? MaleUnderwear { get; set; }

        /// <summary>
        /// Confidence score for miniskirt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("miniskirt")]
        public double? Miniskirt { get; set; }

        /// <summary>
        /// Confidence score for other suggestive content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public double? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestiveClasses" /> class.
        /// </summary>
        /// <param name="bikini">
        /// Confidence score for bikini content.
        /// </param>
        /// <param name="cleavage">
        /// Confidence score for cleavage.
        /// </param>
        /// <param name="cleavageCategories"></param>
        /// <param name="lingerie">
        /// Confidence score for lingerie.
        /// </param>
        /// <param name="maleChest">
        /// Confidence score for male chest.
        /// </param>
        /// <param name="maleChestCategories"></param>
        /// <param name="maleUnderwear">
        /// Confidence score for male underwear.
        /// </param>
        /// <param name="miniskirt">
        /// Confidence score for miniskirt.
        /// </param>
        /// <param name="other">
        /// Confidence score for other suggestive content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestiveClasses(
            double? bikini,
            double? cleavage,
            global::Sightengine.SuggestiveClassesCleavageCategories? cleavageCategories,
            double? lingerie,
            double? maleChest,
            global::Sightengine.SuggestiveClassesMaleChestCategories? maleChestCategories,
            double? maleUnderwear,
            double? miniskirt,
            double? other)
        {
            this.Bikini = bikini;
            this.Cleavage = cleavage;
            this.CleavageCategories = cleavageCategories;
            this.Lingerie = lingerie;
            this.MaleChest = maleChest;
            this.MaleChestCategories = maleChestCategories;
            this.MaleUnderwear = maleUnderwear;
            this.Miniskirt = miniskirt;
            this.Other = other;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestiveClasses" /> class.
        /// </summary>
        public SuggestiveClasses()
        {
        }
    }
}