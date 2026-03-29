
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Context information for nudity analysis.
    /// </summary>
    public sealed partial class NudityContext
    {
        /// <summary>
        /// Confidence the image is at a sea, lake, or pool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sea_lake_pool")]
        public double? SeaLakePool { get; set; }

        /// <summary>
        /// Confidence the image is in an outdoor setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outdoor_other")]
        public double? OutdoorOther { get; set; }

        /// <summary>
        /// Confidence the image is in an indoor setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indoor_other")]
        public double? IndoorOther { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NudityContext" /> class.
        /// </summary>
        /// <param name="seaLakePool">
        /// Confidence the image is at a sea, lake, or pool.
        /// </param>
        /// <param name="outdoorOther">
        /// Confidence the image is in an outdoor setting.
        /// </param>
        /// <param name="indoorOther">
        /// Confidence the image is in an indoor setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NudityContext(
            double? seaLakePool,
            double? outdoorOther,
            double? indoorOther)
        {
            this.SeaLakePool = seaLakePool;
            this.OutdoorOther = outdoorOther;
            this.IndoorOther = indoorOther;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NudityContext" /> class.
        /// </summary>
        public NudityContext()
        {
        }
    }
}