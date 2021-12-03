using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLib.Collection
{
    /// <summary>
    /// ICollection扩展
    /// </summary>
    public static class Collection
    {
        /// <summary>
        /// 如果集合是空的, 返回<c>true</c>, 否则返回<c>false</c>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>布尔值</returns>
        public static bool IsEmpty<T>(this ICollection<T> collection)
        {
            return collection.Count == 0;
        }
    }
}
