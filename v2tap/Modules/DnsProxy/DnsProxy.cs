using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace v2tap.Modules.DnsProxy
{
    public class DnsProxy
    {
        /// <summary>
        /// 是否已启动
        /// </summary>
        public bool isStarted = false;

        /// <summary>
        /// 被代理的地址
        /// </summary>
        public string Address = "114.114.114.114";

        /// <summary>
        /// 被代理的端口
        /// </summary>
        public int Port = 53;

        /// <summary>
        /// 启动
        /// </summary>
        public void Start(string ip)
        {

        }

        public void Stop()
        {
            using (var client = new UdpClient("127.0.0.1", 53))
            {
                var data = new byte[] { 0x00 };
                client.Send(data, data.Length);
            }
        }
    }
}
