using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2tap
{
    /// <summary>
    /// 全局变量
    /// </summary>
    public static class Global
    {
        /// <summary>
        /// 路径
        /// </summary>
        public static class Path
        {
            /// <summary>
            /// 日志目录
            /// </summary>
            public static string LoggingDirectory = "logging";

            /// <summary>
            /// v2tap 日志
            /// </summary>
            public static string v2tapLogging = "v2tap.txt";

            /// <summary>
            /// v2ray 日志
            /// </summary>
            public static string v2rayLogging = "v2ray.txt";

            /// <summary>
            /// tun2socks 日志
            /// </summary>
            public static string tun2socksLogging = "tun2socks.txt";

            /// <summary>
            /// 模式目录
            /// </summary>
            public static string ModeDirectory = "mode";
        }

        /// <summary>
        /// 日志等级
        /// </summary>
        public enum Level
        {
            /// <summary>
            /// 调试
            /// </summary>
            DEBUG,

            /// <summary>
            /// 信息
            /// </summary>
            INFO,

            /// <summary>
            /// 警告
            /// </summary>
            WARNING,

            /// <summary>
            /// 错误
            /// </summary>
            ERROR
        }

        /// <summary>
        /// 窗体
        /// </summary>
        public static class Form
        {
            /// <summary>
            /// 主窗体
            /// </summary>
            public static Forms.MainForm MainForm;

            /// <summary>
            /// 编辑
            /// </summary>
            public static Forms.EditForm EditForm;

            /// <summary>
            /// 导入
            /// </summary>
            public static Forms.ImportForm ImportForm;

            /// <summary>
            /// 高级设置
            /// </summary>
            public static Forms.AdvancedForm AdvancedForm;
        }

        /// <summary>
        /// 配置信息
        /// </summary>
        public static class Configs
        {
            /// <summary>
            /// TUN/TAP 地址
            /// </summary>
            public static string TUNTAPAddress;

            /// <summary>
            /// TUN/TAP 网关
            /// </summary>
            public static string TUNTAPGateway;

            /// <summary>
            /// TUN/TAP 掩码
            /// </summary>
            public static string TUNTAPNetmask;

            /// <summary>
            /// TUN/TAP DNS
            /// </summary>
            public static string TUNTAPDNS;

            /// <summary>
            /// TUN/TAP 跃点数
            /// </summary>
            public static int TUNTAPMetric;

            /// <summary>
            /// 自动降低适配器跃点数
            /// </summary>
            public static bool AutoAdapterMetric;

            /// <summary>
            /// 适配器地址
            /// </summary>
            public static List<string> AdapterAddress = new List<string>();

            /// <summary>
            /// 适配器地址索引
            /// </summary>
            public static int AdapterAddressIndex;

            /// <summary>
            /// 适配器网关
            /// </summary>
            public static List<string> AdapterGateway = new List<string>();

            /// <summary>
            /// 适配器网关索引
            /// </summary>
            public static int AdapterGatewayIndex;

            /// <summary>
            /// 自动检测出网适配器
            /// </summary>
            public static bool AutoCheckAdapter;

            /// <summary>
            /// v2ray 日志等级
            /// </summary>
            public static string v2rayLoggingLevel;
        }

        /// <summary>
        /// 代理信息
        /// </summary>
        public static List<Objects.Server> Proxies = new List<Objects.Server>();

        /// <summary>
        /// 模式信息
        /// </summary>
        public static List<Objects.Mode> Modes = new List<Objects.Mode>();
    }
}
