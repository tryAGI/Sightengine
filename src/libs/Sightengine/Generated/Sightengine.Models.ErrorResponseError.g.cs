
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseError
    {
        /// <summary>
        /// Error type code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="type">
        /// Error type code.
        /// </param>
        /// <param name="code">
        /// Error code.
        /// </param>
        /// <param name="message">
        /// Error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseError(
            int? type,
            int? code,
            string? message)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        public ErrorResponseError()
        {
        }
    }
}