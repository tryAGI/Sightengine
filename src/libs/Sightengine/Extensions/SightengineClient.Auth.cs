#nullable enable

namespace Sightengine;

/// <summary>
/// Sightengine uses dual query parameters (api_user + api_secret) for authentication.
/// The SDK constructor accepts "api_user:api_secret" as the apiKey parameter.
/// The PrepareRequest hook intercepts the Bearer token, removes the Authorization header,
/// and appends api_user and api_secret as query parameters to every request.
/// </summary>
public partial class SightengineClient
{
    /// <summary>
    /// Creates a new instance of the SightengineClient with separate api_user and api_secret.
    /// </summary>
    /// <param name="apiUser">Your Sightengine API user ID.</param>
    /// <param name="apiSecret">Your Sightengine API secret.</param>
    /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
    /// <param name="baseUri">The base URL for the API.</param>
    public SightengineClient(
        string apiUser,
        string apiSecret,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null)
        : this(
            apiKey: apiUser + ":" + apiSecret,
            httpClient: httpClient,
            baseUri: baseUri)
    {
    }

#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } token })
        {
            // Remove the Authorization header — Sightengine uses query params, not headers
            request.Headers.Authorization = null;

            // Split token into api_user and api_secret
            var parts = token.Split(':');
            if (parts.Length == 2)
            {
                var apiUser = parts[0];
                var apiSecret = parts[1];

                // Append api_user and api_secret as query parameters
                var uriBuilder = new global::System.UriBuilder(request.RequestUri!);
                var query = uriBuilder.Query;
                var separator = string.IsNullOrEmpty(query) || query == "?" ? "" : "&";
                if (query.StartsWith('?'))
                {
                    query = query[1..];
                }
                uriBuilder.Query = query + separator +
                    "api_user=" + global::System.Uri.EscapeDataString(apiUser) +
                    "&api_secret=" + global::System.Uri.EscapeDataString(apiSecret);
                request.RequestUri = uriBuilder.Uri;
            }
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
