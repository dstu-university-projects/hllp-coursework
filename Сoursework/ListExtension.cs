using System;
using System.Collections.Generic;
using System.Linq;

namespace Сoursework
{
    public static class ListExtension
    {
        public static int FirstIndexWhere<T>(this IList<T> list, Predicate<T> predicate)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (predicate(list[index]))
                {
                    return index;
                }
            }
            return -1;
        }

        public static int LastIndexWhere<T>(this IList<T> list, Predicate<T> predicate)
        {
            return list.Count - FirstIndexWhere(list.Reverse().ToArray(), predicate) - 1;
        }
    }
}
