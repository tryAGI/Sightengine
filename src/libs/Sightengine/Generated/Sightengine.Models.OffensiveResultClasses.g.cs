
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OffensiveResultClasses
    {
        /// <summary>
        /// Confidence score for Nazi content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nazi")]
        public double? Nazi { get; set; }

        /// <summary>
        /// Confidence score for Confederate content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confederate")]
        public double? Confederate { get; set; }

        /// <summary>
        /// Confidence score for supremacist content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supremacist")]
        public double? Supremacist { get; set; }

        /// <summary>
        /// Confidence score for terrorist content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terrorist")]
        public double? Terrorist { get; set; }

        /// <summary>
        /// Confidence score for middle finger gesture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_finger")]
        public double? MiddleFinger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OffensiveResultClasses" /> class.
        /// </summary>
        /// <param name="nazi">
        /// Confidence score for Nazi content.
        /// </param>
        /// <param name="confederate">
        /// Confidence score for Confederate content.
        /// </param>
        /// <param name="supremacist">
        /// Confidence score for supremacist content.
        /// </param>
        /// <param name="terrorist">
        /// Confidence score for terrorist content.
        /// </param>
        /// <param name="middleFinger">
        /// Confidence score for middle finger gesture.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OffensiveResultClasses(
            double? nazi,
            double? confederate,
            double? supremacist,
            double? terrorist,
            double? middleFinger)
        {
            this.Nazi = nazi;
            this.Confederate = confederate;
            this.Supremacist = supremacist;
            this.Terrorist = terrorist;
            this.MiddleFinger = middleFinger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffensiveResultClasses" /> class.
        /// </summary>
        public OffensiveResultClasses()
        {
        }
    }
}