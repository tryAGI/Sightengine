
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Information about the API request.
    /// </summary>
    public sealed partial class RequestInfo
    {
        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unix timestamp of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Number of operations consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        public int? Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique request identifier.
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp of the request.
        /// </param>
        /// <param name="operations">
        /// Number of operations consumed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestInfo(
            string? id,
            double? timestamp,
            int? operations)
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.Operations = operations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestInfo" /> class.
        /// </summary>
        public RequestInfo()
        {
        }
    }
}