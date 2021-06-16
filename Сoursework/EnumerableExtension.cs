
using System.Collections.Generic;

namespace Сoursework
{
    public static class EnumerableExtension
    {
        public static string ToPresentationString<T>(this IEnumerable<T> enumerable)
        {
            return "[" + string.Join(", ", enumerable) + "]";
        }
    }
}
