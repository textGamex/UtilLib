using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

namespace UtilityLib.Net
{
    public static class Tools
    {   
        //public static bool IsOnline()
        //{
        //    var ping = new Ping();

        //    var result = ping.Send("https://www.bilibili.com/");
        //    if (result.Status != IPStatus.Success)
        //    {   
        //        Console.WriteLine("未联网");
        //    }
        //    return true;
        //}

        /// <summary>
        /// 检测设备联网状态
        /// </summary>
        /// <returns>如果联网, 返回<c>true</c>, 否则返回<c>false</c></returns>
        public static bool IsOnline()
        {
            try
            {
                Dns.GetHostEntry("www.baidu.com");
                return true;
            }
            catch (SocketException)
            {
            }
            try
            {
                Dns.GetHostEntry("music.163.com");
                return true;
            }
            catch (SocketException)
            {
            }
            try
            {
                Dns.GetHostEntry("www.tencent.com");
                return true;
            }
            catch (SocketException)
            {
            }
            return false;
        }
    }
}
