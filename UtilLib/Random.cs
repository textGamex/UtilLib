using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLib
{
    /// <summary>
    /// <see cref="Random"/>扩展
    /// </summary>
    public static class RandomExtend
    {
        /// <summary>
        /// 返回一个有符号Int64, 范围为 0 到 Int64.MaxValue
        /// </summary>
        /// <param name="random"></param>
        /// <returns>一个有符号Int64, 范围为 0 到 Int64.MaxValue</returns>
        public static long NextSignedInt64(this Random random)
        {
            long number = (long)(random.NextDouble() * long.MaxValue);
            return number;
        }

        public static bool NextBoolean(this Random random, double trueProbability)
        {
            return random.NextDouble() <= trueProbability;
        }
    }
}
