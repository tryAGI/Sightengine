#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Image (URL)<br/>
        /// Moderate an image by URL using one or more detection models.<br/>
        /// Supports nudity, violence, gore, weapons, drugs, alcohol, offensive content,<br/>
        /// self-harm, scam detection, face analysis, text-in-image (OCR), QR codes,<br/>
        /// AI-generated image detection, image type, and quality assessment.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="models"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.ImageCheckResponse> CheckImageByUrlAsync(
            string url,
            string models,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}