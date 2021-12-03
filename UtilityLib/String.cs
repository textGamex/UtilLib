using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UtilityLib
{
    /// <summary>
    /// <seealso cref="String"/>扩展
    /// </summary>
    public static class StringExtend
    {
        /// <summary>
        /// 获取字符串的MD5码
        /// </summary>
        /// <param name="input">字符串</param>
        /// <returns>字符串的MD5码</returns>
        public static string MD5Hash(this string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; ++i)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获得字符串的SHA256码
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字符串的SHA256码</returns>
        public static string SHA256(this string str)
        {
            //如果str有中文，不同Encoding的sha是不同的!!
            byte[] SHA256Data = Encoding.UTF8.GetBytes(str);

            SHA256Managed Sha256 = new SHA256Managed();
            byte[] by = Sha256.ComputeHash(SHA256Data);

            return BitConverter.ToString(by).Replace("-", "").ToLower(); //64
        }

        /// <summary>
        /// 获得一个已经拼接好的URI链接
        /// </summary>
        /// <param name="uri">URI链接</param>
        /// <param name="uriParameter">参数字典</param>
        /// <returns>一个已经拼接好的URI链接</returns>
        public static string GetCompleteUrl(this string uri, Dictionary<string, string> uriParameter)
        {
            bool firstParameter = true;
            var sb = new StringBuilder(uri);
            foreach (var key in uriParameter.Keys)
            {
                if (firstParameter)
                {
                    sb.Append('?');
                    firstParameter = false;
                }
                else
                {
                    sb.Append('&');
                }
                sb.Append(key).Append('=').Append(uriParameter[key]);
            }
            return sb.ToString();
        }
    }
}
