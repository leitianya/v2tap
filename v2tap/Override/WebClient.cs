using System;
using System.Net;

namespace v2tap.Override
{
    public class WebClient : System.Net.WebClient
    {
        /// <summary>
        /// 超时
        /// </summary>
        public int Timeout = 4000;

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            request.Timeout = Timeout;

            return request;
        }

        public static WebClient GetClient()
        {
            return new WebClient();
        }
    }
}
