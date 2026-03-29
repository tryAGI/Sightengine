
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Moderation mode (rules or username).
    /// </summary>
    public enum CheckTextRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Rules,
        /// <summary>
        /// 
        /// </summary>
        Username,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckTextRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckTextRequestMode value)
        {
            return value switch
            {
                CheckTextRequestMode.Rules => "rules",
                CheckTextRequestMode.Username => "username",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckTextRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "rules" => CheckTextRequestMode.Rules,
                "username" => CheckTextRequestMode.Username,
                _ => null,
            };
        }
    }
}