#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Image (Upload)<br/>
        /// Moderate an uploaded image using one or more detection models.<br/>
        /// Supports nudity, violence, gore, weapons, drugs, alcohol, offensive content,<br/>
        /// self-harm, scam detection, face analysis, text-in-image (OCR), QR codes,<br/>
        /// AI-generated image detection, image type, and quality assessment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.ImageCheckResponse> CheckImageByUploadAsync(

            global::Sightengine.CheckImageByUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Image (Upload)<br/>
        /// Moderate an uploaded image using one or more detection models.<br/>
        /// Supports nudity, violence, gore, weapons, drugs, alcohol, offensive content,<br/>
        /// self-harm, scam detection, face analysis, text-in-image (OCR), QR codes,<br/>
        /// AI-generated image detection, image type, and quality assessment.
        /// </summary>
        /// <param name="media">
        /// The image file to analyze.
        /// </param>
        /// <param name="medianame">
        /// The image file to analyze.
        /// </param>
        /// <param name="models">
        /// Comma-separated list of detection models to apply.<br/>
        /// Available models: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, face-attributes, text-content,<br/>
        /// qr-content, genai, type, quality.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.ImageCheckResponse> CheckImageByUploadAsync(
            byte[] media,
            string medianame,
            string models,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}