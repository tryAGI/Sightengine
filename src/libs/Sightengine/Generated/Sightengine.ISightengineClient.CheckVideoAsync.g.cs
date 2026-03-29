#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Video (Asynchronous)<br/>
        /// Start asynchronous video or live stream moderation.<br/>
        /// Results are delivered via the callback URL.<br/>
        /// Supports videos longer than 60 seconds and live streams<br/>
        /// (HLS, RTMP, RTMPS, RTSP, RTP, MPEG-DASH).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.VideoCheckAsyncResponse> CheckVideoAsyncAsync(

            global::Sightengine.CheckVideoAsyncRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Video (Asynchronous)<br/>
        /// Start asynchronous video or live stream moderation.<br/>
        /// Results are delivered via the callback URL.<br/>
        /// Supports videos longer than 60 seconds and live streams<br/>
        /// (HLS, RTMP, RTMPS, RTSP, RTP, MPEG-DASH).
        /// </summary>
        /// <param name="media">
        /// The video file to analyze (use this OR stream_url).
        /// </param>
        /// <param name="medianame">
        /// The video file to analyze (use this OR stream_url).
        /// </param>
        /// <param name="streamUrl">
        /// Public URL of the video or live stream.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL to receive moderation results.
        /// </param>
        /// <param name="models">
        /// Comma-separated list of detection models.<br/>
        /// Available: nudity-2.1, gore-2.0, weapon, drugs, violence,<br/>
        /// alcohol, offensive, self-harm, scam.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.VideoCheckAsyncResponse> CheckVideoAsyncAsync(
            string models,
            byte[]? media = default,
            string? medianame = default,
            string? streamUrl = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}