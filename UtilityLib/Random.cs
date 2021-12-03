using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLib
{
    /// <summary>
    /// <seealso cref="Random"/>扩展
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

        /// <summary>
        /// 以指定的概率返回<c>true</c>
        /// </summary>
        /// <param name="random"></param>
        /// <param name="trueProbability">返回<c>
        /// true</c>的概率</param>
        /// <returns><c>true</c>或<c>false</c></returns>
        public static bool NextBoolean(this Random random, double trueProbability)
        {
            if (trueProbability <= 0.0)
                return false;
            return random.NextDouble() <= trueProbability;
        }
    }
}
