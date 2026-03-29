#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Submit Feedback<br/>
        /// Submit moderation feedback to improve model accuracy.<br/>
        /// Feedback submissions are free and do not count as operations.<br/>
        /// The image is used to continuously improve the specified model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.FeedbackResponse> SubmitFeedbackAsync(

            global::Sightengine.SubmitFeedbackRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Feedback<br/>
        /// Submit moderation feedback to improve model accuracy.<br/>
        /// Feedback submissions are free and do not count as operations.<br/>
        /// The image is used to continuously improve the specified model.
        /// </summary>
        /// <param name="url">
        /// Public URL to the image (use this OR media).
        /// </param>
        /// <param name="media">
        /// The image file (use this OR url).
        /// </param>
        /// <param name="medianame">
        /// The image file (use this OR url).
        /// </param>
        /// <param name="model">
        /// The model that classified the image.<br/>
        /// Available: nudity, gore, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam, genai.
        /// </param>
        /// <param name="class">
        /// The expected/correct classification result.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.FeedbackResponse> SubmitFeedbackAsync(
            string model,
            string @class,
            string? url = default,
            byte[]? media = default,
            string? medianame = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}