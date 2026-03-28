
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamMode
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Extended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamMode value)
        {
            return value switch
            {
                StreamMode.Default => "default",
                StreamMode.Extended => "extended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => StreamMode.Default,
                "extended" => StreamMode.Extended,
                _ => null,
            };
        }
    }
}