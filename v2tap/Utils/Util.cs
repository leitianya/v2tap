using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace v2tap.Utils
{
    public static class Util
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="content">日志内容</param>
        public static void WriteLine(string content, Global.Level level)
        {
            var path = String.Format("{0}\\{1}", Global.Path.LoggingDirectory, Global.Path.v2tapLogging);
            var info = String.Format("[{0}][{1}] {2}\n", DateTime.Now.ToString(), "{0}", content);

            switch (level)
            {
                case Global.Level.DEBUG:
                    File.AppendAllText(path, String.Format(info, "DBUG"));
                    break;
                case Global.Level.INFO:
                    File.AppendAllText(path, String.Format(info, "INFO"));
                    break;
                case Global.Level.WARNING:
                    File.AppendAllText(path, String.Format(info, "WARN"));
                    break;
                case Global.Level.ERROR:
                    File.AppendAllText(path, String.Format(info, "EROR"));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 执行命令行命令
        /// </summary>
        /// <param name="content">命令内容</param>
        public static void ExecuteCommand(string content)
        {
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + content;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        /// <summary>
        /// 从文件中加载配置信息
        /// </summary>
        public static void InitConfigsFromFile()
        {
            var data = new IniParser.FileIniDataParser().ReadFile("v2tap.ini");

            Global.Configs.TUNTAPAddress = data["v2tap"]["TUNTAPAddress"];
            Global.Configs.TUNTAPGateway = data["v2tap"]["TUNTAPGateway"];
            Global.Configs.TUNTAPNetmask = data["v2tap"]["TUNTAPNetmask"];
            Global.Configs.TUNTAPDNS = data["v2tap"]["TUNTAPDNS"];
            Global.Configs.TUNTAPMetric = int.Parse(data["v2tap"]["TUNTAPMetric"]);
            Global.Configs.AutoAdapterMetric = Boolean.Parse(data["v2tap"]["AutoAdapterMetric"]);
            Global.Configs.AutoCheckAdapter = Boolean.Parse(data["v2tap"]["AutoCheckAdapter"]);
            Global.Configs.v2rayLoggingLevel = data["v2tap"]["v2rayLoggingLevel"];
        }

        /// <summary>
        /// 将配置信息保存到文件中
        /// </summary>
        public static void SaveConfigsToFile()
        {
            var data = new IniParser.FileIniDataParser().ReadFile("v2tap.ini");

            data["v2tap"]["TUNTAPAddress"] = Global.Configs.TUNTAPAddress;
            data["v2tap"]["TUNTAPGateway"] = Global.Configs.TUNTAPGateway;
            data["v2tap"]["TUNTAPNetmask"] = Global.Configs.TUNTAPNetmask;
            data["v2tap"]["TUNTAPDNS"] = Global.Configs.TUNTAPDNS;
            data["v2tap"]["TUNTAPMetric"] = Global.Configs.TUNTAPMetric.ToString();
            data["v2tap"]["AutoAdapterMetric"] = Global.Configs.AutoAdapterMetric.ToString();
            data["v2tap"]["AutoCheckAdapter"] = Global.Configs.AutoCheckAdapter.ToString();
            data["v2tap"]["v2rayLoggingLevel"] = Global.Configs.v2rayLoggingLevel;

            File.WriteAllText("v2tap.ini", data.ToString());
        }

        /// <summary>
        /// 从文件中加载服务器配置信息
        /// </summary>
        public static void InitServersFromFile()
        {
            Global.Proxies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Objects.Server>>(File.ReadAllText("v2tap.json"));
        }

        /// <summary>
        /// 将服务器配置信息保存到文件中
        /// </summary>
        public static void SaveServersToFile()
        {
            File.WriteAllText("v2tap.json", Newtonsoft.Json.JsonConvert.SerializeObject(Global.Proxies));
        }

        public static void InitAdapter()
        {
            if (Global.Configs.AutoAdapterMetric)
            {
                using (var client = new UdpClient("114.114.114.114", 53))
                {
                    var address = ((IPEndPoint)client.Client.LocalEndPoint).Address;

                    int addressCount = 0;
                    int gatewayCount = 0;
                    bool addressGeted = false;

                    var adapters = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (var adapter in adapters)
                    {
                        var properties = adapter.GetIPProperties();

                        foreach (var information in properties.UnicastAddresses)
                        {
                            if (information.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                var ip = information.Address.ToString();

                                if (ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192."))
                                {
                                    if (Equals(information.Address, address))
                                    {
                                        addressGeted = true;
                                    }
                                    else
                                    {
                                        if (!addressGeted) addressCount++;
                                    }

                                    Global.Configs.AdapterAddress.Add(ip);
                                }
                            }
                        }

                        foreach (var information in properties.GatewayAddresses)
                        {
                            if (information.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                string IP = information.Address.ToString();

                                if (IP.StartsWith("10.") || IP.StartsWith("172.") || IP.StartsWith("192."))
                                {
                                    if (!addressGeted)
                                    {
                                        gatewayCount++;
                                    }

                                    Global.Configs.AdapterGateway.Add(IP);
                                }
                            }
                        }
                    }

                    Global.Configs.AdapterAddressIndex = addressCount;
                    Global.Configs.AdapterGatewayIndex = gatewayCount;
                }
            }
        }

        /// <summary>
        /// 取 ID 在服务器配置信息中的索引号
        /// </summary>
        /// <param name="text">ID</param>
        /// <returns>索引号</returns>
        public static int GetServerIndexByID(string text)
        {
            for (int i = 0; i < Global.Proxies.Count; i++)
            {
                if (Global.Proxies[i].ID == text)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// 取备注在服务器配置信息中的索引号
        /// </summary>
        /// <param name="text">备注</param>
        /// <returns>索引号</returns>
        public static int GetServerIndexByRemark(string text)
        {
            for (int i = 0; i < Global.Proxies.Count; i++)
            {
                if (Global.Proxies[i].Remark == text)
                {
                    return i;
                }
            }

            return -1;
        }

        public static string ProcessBandwidth(long bandwidth)
        {
            var result = ((double)bandwidth) / 1024;

            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " KB";
            }

            result = result / 1024;
            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " MB";
            }

            result = result / 1024;
            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " GB";
            }

            result = result / 1024;
            return Math.Round(result, 2).ToString() + " TB";
        }

        /// <summary>
        /// 处理状态流量信息
        /// </summary>
        /// <param name="bandwidth">流量</param>
        /// <returns>处理好的信息</returns>
        public static string ProcessStatusBandwidth(long bandwidth)
        {
            var result = ((double)bandwidth) / 1024;

            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " KB/s";
            }

            result = result / 1024;
            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " MB/s";
            }

            result = result / 1024;
            if (result < 1024)
            {
                return Math.Round(result, 2).ToString() + " GB/s";
            }

            result = result / 1024;
            return Math.Round(result, 2).ToString() + " TB/s";
        }
    }
}
