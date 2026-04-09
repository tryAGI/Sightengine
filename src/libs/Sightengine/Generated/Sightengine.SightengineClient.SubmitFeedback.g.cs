
#nullable enable

namespace Sightengine
{
    public partial class SightengineClient
    {


        private static readonly global::Sightengine.EndPointSecurityRequirement s_SubmitFeedbackSecurityRequirement0 =
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
        private static readonly global::Sightengine.EndPointSecurityRequirement[] s_SubmitFeedbackSecurityRequirements =
            new global::Sightengine.EndPointSecurityRequirement[]
            {                s_SubmitFeedbackSecurityRequirement0,
            };
        partial void PrepareSubmitFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Sightengine.SubmitFeedbackRequest request);
        partial void PrepareSubmitFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Sightengine.SubmitFeedbackRequest request);
        partial void ProcessSubmitFeedbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSubmitFeedbackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Submit Feedback<br/>
        /// Submit moderation feedback to improve model accuracy.<br/>
        /// Feedback submissions are free and do not count as operations.<br/>
        /// The image is used to continuously improve the specified model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Sightengine.FeedbackResponse> SubmitFeedbackAsync(

            global::Sightengine.SubmitFeedbackRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSubmitFeedbackArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Sightengine.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SubmitFeedbackSecurityRequirements,
                operationName: "SubmitFeedbackAsync");

            var __pathBuilder = new global::Sightengine.PathBuilder(
                path: "/feedback.json",
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
            if (request.Url != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Url}"),
                    name: "\"url\"");
            } 
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
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "\"model\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Class}"),
                name: "\"class\"");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSubmitFeedbackRequest(
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
            ProcessSubmitFeedbackResponse(
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
                ProcessSubmitFeedbackResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Sightengine.FeedbackResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Sightengine.FeedbackResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        public async global::System.Threading.Tasks.Task<global::Sightengine.FeedbackResponse> SubmitFeedbackAsync(
            string model,
            string @class,
            string? url = default,
            byte[]? media = default,
            string? medianame = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Sightengine.SubmitFeedbackRequest
            {
                Url = url,
                Media = media,
                Medianame = medianame,
                Model = model,
                Class = @class,
            };

            return await SubmitFeedbackAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}