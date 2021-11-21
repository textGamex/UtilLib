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
        public static long NextSignedInt64(this Random random)
        {
            long number = (long)(random.NextDouble() * long.MaxValue);
            if (random.NextDouble() <= 0.5)
            {
                return number;
            }
            return -number;
        }

        public static bool NextBoolean(this Random random, double trueProbability)
        {
            return random.NextDouble() <= trueProbability;
        }
    }
}
