#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Image with Workflow (URL)<br/>
        /// Moderate an image by URL using a pre-configured workflow.<br/>
        /// Workflows define custom rules and actions from the dashboard.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="workflow"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.WorkflowCheckResponse> CheckWorkflowByUrlAsync(
            string url,
            string workflow,
            global::Sightengine.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}