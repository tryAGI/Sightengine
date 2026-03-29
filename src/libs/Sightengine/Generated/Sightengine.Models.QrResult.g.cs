
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// QR code detection results.
    /// </summary>
    public sealed partial class QrResult
    {
        /// <summary>
        /// List of detected QR codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qr_codes")]
        public global::System.Collections.Generic.IList<global::Sightengine.QrResultQrCode>? QrCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QrResult" /> class.
        /// </summary>
        /// <param name="qrCodes">
        /// List of detected QR codes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QrResult(
            global::System.Collections.Generic.IList<global::Sightengine.QrResultQrCode>? qrCodes)
        {
            this.QrCodes = qrCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrResult" /> class.
        /// </summary>
        public QrResult()
        {
        }
    }
}