
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Nudity detection results with confidence scores (0-1).
    /// </summary>
    public sealed partial class NudityResult
    {
        /// <summary>
        /// Confidence score for sexual activity content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual_activity")]
        public double? SexualActivity { get; set; }

        /// <summary>
        /// Confidence score for sexual display content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual_display")]
        public double? SexualDisplay { get; set; }

        /// <summary>
        /// Confidence score for erotic content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erotica")]
        public double? Erotica { get; set; }

        /// <summary>
        /// Confidence score for sex toy content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sextoy")]
        public double? Sextoy { get; set; }

        /// <summary>
        /// Overall suggestive content score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestive")]
        public double? Suggestive { get; set; }

        /// <summary>
        /// Breakdown of suggestive content categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestive_classes")]
        public global::Sightengine.SuggestiveClasses? SuggestiveClasses { get; set; }

        /// <summary>
        /// Confidence score for no nudity detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("none")]
        public double? None { get; set; }

        /// <summary>
        /// Context information for nudity analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Sightengine.NudityContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NudityResult" /> class.
        /// </summary>
        /// <param name="sexualActivity">
        /// Confidence score for sexual activity content.
        /// </param>
        /// <param name="sexualDisplay">
        /// Confidence score for sexual display content.
        /// </param>
        /// <param name="erotica">
        /// Confidence score for erotic content.
        /// </param>
        /// <param name="sextoy">
        /// Confidence score for sex toy content.
        /// </param>
        /// <param name="suggestive">
        /// Overall suggestive content score.
        /// </param>
        /// <param name="suggestiveClasses">
        /// Breakdown of suggestive content categories.
        /// </param>
        /// <param name="none">
        /// Confidence score for no nudity detected.
        /// </param>
        /// <param name="context">
        /// Context information for nudity analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NudityResult(
            double? sexualActivity,
            double? sexualDisplay,
            double? erotica,
            double? sextoy,
            double? suggestive,
            global::Sightengine.SuggestiveClasses? suggestiveClasses,
            double? none,
            global::Sightengine.NudityContext? context)
        {
            this.SexualActivity = sexualActivity;
            this.SexualDisplay = sexualDisplay;
            this.Erotica = erotica;
            this.Sextoy = sextoy;
            this.Suggestive = suggestive;
            this.SuggestiveClasses = suggestiveClasses;
            this.None = none;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NudityResult" /> class.
        /// </summary>
        public NudityResult()
        {
        }
    }
}