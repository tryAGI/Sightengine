
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WeaponResultClasses
    {
        /// <summary>
        /// Confidence score for firearms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firearm")]
        public double? Firearm { get; set; }

        /// <summary>
        /// Confidence score for knives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knife")]
        public double? Knife { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponResultClasses" /> class.
        /// </summary>
        /// <param name="firearm">
        /// Confidence score for firearms.
        /// </param>
        /// <param name="knife">
        /// Confidence score for knives.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WeaponResultClasses(
            double? firearm,
            double? knife)
        {
            this.Firearm = firearm;
            this.Knife = knife;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponResultClasses" /> class.
        /// </summary>
        public WeaponResultClasses()
        {
        }
    }
}