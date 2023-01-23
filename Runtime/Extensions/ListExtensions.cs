using System;
using System.Collections.Generic;

namespace Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Get Last Element of a List<T>
        /// </summary>
        /// <param name="list">The List</param>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>T</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if List.Count == 0</exception>
        public static T GetLast<T>(this IList<T> list)
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return list[list.Count - 1];
        }
    }
}
