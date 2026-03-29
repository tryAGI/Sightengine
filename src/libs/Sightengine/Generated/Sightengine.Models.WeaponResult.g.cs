
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Weapon detection results.
    /// </summary>
    public sealed partial class WeaponResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::Sightengine.WeaponResultClasses? Classes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponResult" /> class.
        /// </summary>
        /// <param name="classes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WeaponResult(
            global::Sightengine.WeaponResultClasses? classes)
        {
            this.Classes = classes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponResult" /> class.
        /// </summary>
        public WeaponResult()
        {
        }
    }
}