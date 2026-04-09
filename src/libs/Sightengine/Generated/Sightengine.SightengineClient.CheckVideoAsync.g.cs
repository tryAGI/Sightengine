
#nullable enable

namespace Sightengine
{
    public partial class SightengineClient
    {


        private static readonly global::Sightengine.EndPointSecurityRequirement s_CheckVideoAsyncSecurityRequirement0 =
            new global::Sightengine.EndPointSecurityRequirement
            {
                Authorizations = new global::Sightengine.EndPointAuthorizationRequirement[]
                {                    new global::Sightengine.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Sightengine.EndPointSecurityRequirement[] s_CheckVideoAsyncSecurityRequirements =
            new global::Sightengine.EndPointSecurityRequirement[]
            {                s_CheckVideoAsyncSecurityRequirement0,
            };
        partial void PrepareCheckVideoAsyncArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Sightengine.CheckVideoAsyncRequest request);
        partial void PrepareCheckVideoAsyncRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Sightengine.CheckVideoAsyncRequest request);
        partial void ProcessCheckVideoAsyncResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCheckVideoAsyncResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Sightengine.VideoCheckAsyncResponse> CheckVideoAsyncAsync(

            global::Sightengine.CheckVideoAsyncRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCheckVideoAsyncArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Sightengine.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CheckVideoAsyncSecurityRequirements,
                operationName: "CheckVideoAsyncAsync");

            var __pathBuilder = new global::Sightengine.PathBuilder(
                path: "/video/check.json",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Media != default)
            {

                var __contentMedia = new global::System.Net.Http.ByteArrayContent(request.Media ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentMedia,
                    name: "\"media\"",
                    fileName: request.Medianame != null ? $"\"{request.Medianame}\"" : string.Empty);
                if (__contentMedia.Headers.ContentDisposition != null)
                {
                    __contentMedia.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.StreamUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StreamUrl}"),
                    name: "\"stream_url\"");
            } 
            if (request.CallbackUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CallbackUrl}"),
                    name: "\"callback_url\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Models}"),
                name: "\"models\"");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCheckVideoAsyncRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCheckVideoAsyncResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Sightengine.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Sightengine.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Sightengine.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Sightengine.ApiException<global::Sightengine.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Sightengine.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Sightengine.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Sightengine.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Sightengine.ApiException<global::Sightengine.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCheckVideoAsyncResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Sightengine.VideoCheckAsyncResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Sightengine.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Sightengine.VideoCheckAsyncResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Sightengine.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Sightengine.VideoCheckAsyncResponse> CheckVideoAsyncAsync(
            string models,
            byte[]? media = default,
            string? medianame = default,
            string? streamUrl = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Sightengine.CheckVideoAsyncRequest
            {
                Media = media,
                Medianame = medianame,
                StreamUrl = streamUrl,
                CallbackUrl = callbackUrl,
                Models = models,
            };

            return await CheckVideoAsyncAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}