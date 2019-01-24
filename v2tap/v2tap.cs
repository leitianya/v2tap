using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace v2tap
{
    public static class v2tap
    {
        public static String[] RequiredFile = new String[]
        {
            "tun2socks.exe",
            "wv2ray.exe",
            "v2ray.exe",
            "v2ctl.exe",
            "geoip.dat",
            "geosite.dat"
        };

        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
#if !DEBUG
                // 检查文件
                foreach (var file in RequiredFile)
                {
                    if (!File.Exists(file))
                    {
                        MessageBox.Show($"缺失重要文件：{file}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
#endif

                // 日志目录
                if (!Directory.Exists(Global.Path.LoggingDirectory)) Directory.CreateDirectory(Global.Path.LoggingDirectory);

                // 模式目录
                if (!Directory.Exists(Global.Path.ModeDirectory)) Directory.CreateDirectory(Global.Path.ModeDirectory);

                // 默认配置
                if (!File.Exists("v2tap.ini")) File.WriteAllText("v2tap.ini", Encoding.UTF8.GetString(Properties.Resources.defaultConfig));
                if (!File.Exists("v2tap.json")) File.WriteAllText("v2tap.json", Encoding.UTF8.GetString(Properties.Resources.defaultServerConfig));

                // 加载配置
                Utils.Util.InitConfigsFromFile();
                Utils.Util.InitServersFromFile();
                Utils.Util.InitModesFromFile();

                // 初始化适配器
                Utils.Util.InitAdapter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("在初始化配置时发生错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Global.Form.MainForm = new Forms.MainForm());
        }
    }
}
