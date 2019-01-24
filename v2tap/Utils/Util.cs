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
        /// 将 CIDR /xx 翻译为掩码
        /// </summary>
        /// <param name="CIDR">CIDR</param>
        /// <returns>掩码</returns>
        public static string TranslateCIDRToNetmask(string CIDR)
        {
            var dict = new Dictionary<string, string>()
            {
                { "1", "128.0.0.0" },
                { "2", "192.0.0.0" },
                { "3", "224.0.0.0" },
                { "4", "240.0.0.0" },
                { "5", "248.0.0.0" },
                { "6", "252.0.0.0" },
                { "7", "254.0.0.0" },
                { "8", "255.0.0.0" },
                { "9", "255.128.0.0" },
                { "10", "255.192.0.0" },
                { "11", "255.224.0.0" },
                { "12", "255.240.0.0" },
                { "13", "255.248.0.0" },
                { "14", "255.252.0.0" },
                { "15", "255.254.0.0" },
                { "16", "255.255.0.0" },
                { "17", "255.255.128.0" },
                { "18", "255.255.192.0" },
                { "19", "255.255.224.0" },
                { "20", "255.255.240.0" },
                { "21", "255.255.248.0" },
                { "22", "255.255.252.0" },
                { "23", "255.255.254.0" },
                { "24", "255.255.255.0" },
                { "25", "255.255.255.128" },
                { "26", "255.255.255.192" },
                { "27", "255.255.255.224" },
                { "28", "255.255.255.240" },
                { "29", "255.255.255.248" },
                { "30", "255.255.255.252" },
                { "31", "255.255.255.254" },
                { "32", "255.255.255.255" }
            };

            if (dict.ContainsKey(CIDR))
            {
                return dict[CIDR];
            }
            else
            {
                return "255.255.255.255";
            }
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

        /// <summary>
        /// 从文件中加载模式配置信息
        /// </summary>
        public static void InitModesFromFile()
        {
            foreach (var filename in Directory.GetFiles(Global.Path.ModeDirectory, "*.txt"))
            {
                var mode = new Objects.Mode();
                mode.Name = filename
                    .Replace(Global.Path.ModeDirectory + "\\", "")
                    .Replace(".txt", "");

                using (var sr = new StringReader(File.ReadAllText(filename)))
                {
                    string text;

                    while ((text = sr.ReadLine()) != null)
                    {
                        var splited = text.Split('/');
                        mode.Rule.Add(new KeyValuePair<string, string>(splited[0], TranslateCIDRToNetmask(splited[1])));
                    }
                }

                Global.Modes.Add(mode);
            }
        }

        /// <summary>
        /// 加载适配器信息
        /// </summary>
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

        /// <summary>
        /// 取名称在模式信息中的索引号
        /// </summary>
        /// <param name="text">备注</param>
        /// <returns>索引号</returns>
        public static int GetModeIndexByName(string text)
        {
            for (int i = 0; i < Global.Modes.Count; i++)
            {
                if (Global.Modes[i].Name == text)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// 处理流量信息
        /// </summary>
        /// <param name="bandwidth">流量信息</param>
        /// <returns>处理好的信息</returns>
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
    }
}
