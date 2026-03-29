#nullable enable

namespace Sightengine
{
    public partial interface ISightengineClient
    {
        /// <summary>
        /// Check Text<br/>
        /// Moderate text content for profanity, personal information (emails,<br/>
        /// phone numbers, usernames, IP addresses, SSNs), and links.<br/>
        /// Supports rule-based mode for content filtering and username mode<br/>
        /// for validating usernames.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sightengine.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.TextCheckResponse> CheckTextAsync(

            global::Sightengine.CheckTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Text<br/>
        /// Moderate text content for profanity, personal information (emails,<br/>
        /// phone numbers, usernames, IP addresses, SSNs), and links.<br/>
        /// Supports rule-based mode for content filtering and username mode<br/>
        /// for validating usernames.
        /// </summary>
        /// <param name="text">
        /// UTF-8 formatted text to moderate.
        /// </param>
        /// <param name="lang">
        /// ISO 639-1 language code (e.g., en, fr, de).
        /// </param>
        /// <param name="mode">
        /// Moderation mode (rules or username).
        /// </param>
        /// <param name="optCountries">
        /// Comma-separated country codes for phone number detection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sightengine.TextCheckResponse> CheckTextAsync(
            string text,
            string lang,
            global::Sightengine.CheckTextRequestMode mode,
            string? optCountries = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}