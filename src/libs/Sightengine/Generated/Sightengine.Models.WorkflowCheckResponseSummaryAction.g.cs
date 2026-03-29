
#nullable enable

namespace Sightengine
{
    /// <summary>
    /// Recommended action (accept or reject).
    /// </summary>
    public enum WorkflowCheckResponseSummaryAction
    {
        /// <summary>
        /// 
        /// </summary>
        Accept,
        /// <summary>
        /// 
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCheckResponseSummaryActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCheckResponseSummaryAction value)
        {
            return value switch
            {
                WorkflowCheckResponseSummaryAction.Accept => "accept",
                WorkflowCheckResponseSummaryAction.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCheckResponseSummaryAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => WorkflowCheckResponseSummaryAction.Accept,
                "reject" => WorkflowCheckResponseSummaryAction.Reject,
                _ => null,
            };
        }
    }
}