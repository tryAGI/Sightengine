#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Image with Workflow (Upload)<br/>
        /// Moderate an uploaded image using a pre-configured workflow.<br/>
        /// Workflows define custom rules and actions from the dashboard.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.WorkflowCheckResponse> CheckWorkflowByUploadAsync(

            global::Sightengine.CheckWorkflowByUploadRequest request,
            global::Sightengine.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Image with Workflow (Upload)<br/>
        /// Moderate an uploaded image using a pre-configured workflow.<br/>
        /// Workflows define custom rules and actions from the dashboard.
        /// </summary>
        /// <param name="media">
        /// The image file to analyze.
        /// </param>
        /// <param name="medianame">
        /// The image file to analyze.
        /// </param>
        /// <param name="workflow">
        /// Workflow ID from the Sightengine dashboard.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.WorkflowCheckResponse> CheckWorkflowByUploadAsync(
            byte[] media,
            string medianame,
            string workflow,
            global::Sightengine.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}