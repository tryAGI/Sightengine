
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QrResultQrCode
    {
        /// <summary>
        /// Decoded QR code data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Type of QR code content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QrResultQrCode" /> class.
        /// </summary>
        /// <param name="data">
        /// Decoded QR code data.
        /// </param>
        /// <param name="type">
        /// Type of QR code content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QrResultQrCode(
            string? data,
            string? type)
        {
            this.Data = data;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrResultQrCode" /> class.
        /// </summary>
        public QrResultQrCode()
        {
        }
    }
}