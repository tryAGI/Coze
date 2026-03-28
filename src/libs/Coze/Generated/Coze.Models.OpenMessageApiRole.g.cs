
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenMessageApiRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenMessageApiRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenMessageApiRole value)
        {
            return value switch
            {
                OpenMessageApiRole.Assistant => "assistant",
                OpenMessageApiRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenMessageApiRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OpenMessageApiRole.Assistant,
                "user" => OpenMessageApiRole.User,
                _ => null,
            };
        }
    }
}