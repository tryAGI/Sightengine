
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Response from the image moderation check endpoint.
    /// </summary>
    public sealed partial class ImageCheckResponse
    {
        /// <summary>
        /// Response status (success or failure).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Information about the API request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Sightengine.RequestInfo? Request { get; set; }

        /// <summary>
        /// Nudity detection results with confidence scores (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nudity")]
        public global::Sightengine.NudityResult? Nudity { get; set; }

        /// <summary>
        /// Overall weapon detection score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weapon")]
        public double? Weapon { get; set; }

        /// <summary>
        /// Weapon detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weapons_classes")]
        public global::Sightengine.WeaponResult? WeaponsClasses { get; set; }

        /// <summary>
        /// Alcohol detection score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alcohol")]
        public double? Alcohol { get; set; }

        /// <summary>
        /// Overall drug detection score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drugs")]
        public double? Drugs { get; set; }

        /// <summary>
        /// Drug detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drugs_classes")]
        public global::Sightengine.DrugResult? DrugsClasses { get; set; }

        /// <summary>
        /// Offensive content detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offensive")]
        public global::Sightengine.OffensiveResult? Offensive { get; set; }

        /// <summary>
        /// Gore and disturbing content detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gore")]
        public global::Sightengine.GoreResult? Gore { get; set; }

        /// <summary>
        /// Violence detection score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public double? Violence { get; set; }

        /// <summary>
        /// Self-harm detection score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm")]
        public double? SelfHarm { get; set; }

        /// <summary>
        /// Scam and fraud detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scam")]
        public global::Sightengine.ScamResult? Scam { get; set; }

        /// <summary>
        /// Detected faces with attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faces")]
        public global::System.Collections.Generic.IList<global::Sightengine.DetectedFace>? Faces { get; set; }

        /// <summary>
        /// Text detected in image via OCR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Sightengine.TextContentResult? Text { get; set; }

        /// <summary>
        /// QR code detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qr")]
        public global::Sightengine.QrResult? Qr { get; set; }

        /// <summary>
        /// AI-generated content confidence score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_generated")]
        public double? AiGenerated { get; set; }

        /// <summary>
        /// Image type classification result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Sightengine.ImageTypeResult? Type { get; set; }

        /// <summary>
        /// Image quality assessment results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::Sightengine.ImageQualityResult? Quality { get; set; }

        /// <summary>
        /// Information about the analyzed media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::Sightengine.MediaInfo? Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCheckResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Response status (success or failure).
        /// </param>
        /// <param name="request">
        /// Information about the API request.
        /// </param>
        /// <param name="nudity">
        /// Nudity detection results with confidence scores (0-1).
        /// </param>
        /// <param name="weapon">
        /// Overall weapon detection score.
        /// </param>
        /// <param name="weaponsClasses">
        /// Weapon detection results.
        /// </param>
        /// <param name="alcohol">
        /// Alcohol detection score.
        /// </param>
        /// <param name="drugs">
        /// Overall drug detection score.
        /// </param>
        /// <param name="drugsClasses">
        /// Drug detection results.
        /// </param>
        /// <param name="offensive">
        /// Offensive content detection results.
        /// </param>
        /// <param name="gore">
        /// Gore and disturbing content detection results.
        /// </param>
        /// <param name="violence">
        /// Violence detection score.
        /// </param>
        /// <param name="selfHarm">
        /// Self-harm detection score.
        /// </param>
        /// <param name="scam">
        /// Scam and fraud detection results.
        /// </param>
        /// <param name="faces">
        /// Detected faces with attributes.
        /// </param>
        /// <param name="text">
        /// Text detected in image via OCR.
        /// </param>
        /// <param name="qr">
        /// QR code detection results.
        /// </param>
        /// <param name="aiGenerated">
        /// AI-generated content confidence score.
        /// </param>
        /// <param name="type">
        /// Image type classification result.
        /// </param>
        /// <param name="quality">
        /// Image quality assessment results.
        /// </param>
        /// <param name="media">
        /// Information about the analyzed media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageCheckResponse(
            string? status,
            global::Sightengine.RequestInfo? request,
            global::Sightengine.NudityResult? nudity,
            double? weapon,
            global::Sightengine.WeaponResult? weaponsClasses,
            double? alcohol,
            double? drugs,
            global::Sightengine.DrugResult? drugsClasses,
            global::Sightengine.OffensiveResult? offensive,
            global::Sightengine.GoreResult? gore,
            double? violence,
            double? selfHarm,
            global::Sightengine.ScamResult? scam,
            global::System.Collections.Generic.IList<global::Sightengine.DetectedFace>? faces,
            global::Sightengine.TextContentResult? text,
            global::Sightengine.QrResult? qr,
            double? aiGenerated,
            global::Sightengine.ImageTypeResult? type,
            global::Sightengine.ImageQualityResult? quality,
            global::Sightengine.MediaInfo? media)
        {
            this.Status = status;
            this.Request = request;
            this.Nudity = nudity;
            this.Weapon = weapon;
            this.WeaponsClasses = weaponsClasses;
            this.Alcohol = alcohol;
            this.Drugs = drugs;
            this.DrugsClasses = drugsClasses;
            this.Offensive = offensive;
            this.Gore = gore;
            this.Violence = violence;
            this.SelfHarm = selfHarm;
            this.Scam = scam;
            this.Faces = faces;
            this.Text = text;
            this.Qr = qr;
            this.AiGenerated = aiGenerated;
            this.Type = type;
            this.Quality = quality;
            this.Media = media;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCheckResponse" /> class.
        /// </summary>
        public ImageCheckResponse()
        {
        }
    }
}