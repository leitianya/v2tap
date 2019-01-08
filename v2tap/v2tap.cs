using System;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace v2tap
{
    public static class v2tap
    {
        public static string[] files = new string[]
        {
            "RunHiddenConsole.exe",
            "tun2socks.exe",
            "wv2ray.exe",
            "v2ray.exe",
            "v2ctl.exe",
            "geoip.dat",
            "geosite.dat"
        };

        public static string config = "ewoJImRucyI6IHsKCQkiY2xpZW50SVAiOiAiYWRhcHRlcklQQWRkcmVzcyIsCgkJImhvc3RzIjogewoJCQkibG9jYWxob3N0IjogIjEyNy4wLjAuMSIsCgkJCSJkb21haW46bGFuIjogIjEyNy4wLjAuMSIsCgkJCSJkb21haW46YXJwYSI6ICIxMjcuMC4wLjEiLAoJCQkiZG9tYWluOmxvY2FsIjogIjEyNy4wLjAuMSIKCQl9LAoJCSJzZXJ2ZXJzIjogWwoJCQkidjJyYXlEZWZhdWx0RE5TIiwKCQkJewoJCQkJImFkZHJlc3MiOiAidjJyYXlDaGluYUROUyIsCgkJCQkicG9ydCI6IDUzLAoJCQkJImRvbWFpbnMiOiBbCgkJCQkJImdlb3NpdGU6Y24iCgkJCQldCgkJCX0KCQldCgl9LAoJInJvdXRpbmciOiB7CgkJInN0cmF0ZWd5IjogInJ1bGVzIiwKCQkic2V0dGluZ3MiOiB7CgkJCSJkb21haW5TdHJhdGVneSI6ICJJUElmTm9uTWF0Y2giLAoJCQkicnVsZXMiOiBbCgkJCQl7CgkJCQkJInR5cGUiOiAiZmllbGQiLAoJCQkJCSJkb21haW4iOiBbCgkJCQkJCSJnZW9zaXRlOmNuIgoJCQkJCV0sCgkJCQkJIm91dGJvdW5kVGFnIjogImRpcmVjdE91dGJvdW5kIgoJCQkJfSwKCQkJCXsKCQkJCQkidHlwZSI6ICJmaWVsZCIsCgkJCQkJImlwIjogWwoJCQkJCQkiZ2VvaXA6Y24iLAoJCQkJCQkiZ2VvaXA6cHJpdmF0ZSIKCQkJCQldLAoJCQkJCSJvdXRib3VuZFRhZyI6ImRpcmVjdE91dGJvdW5kIgoJCQkJfQoJCQldCgkJfQoJfSwKCSJpbmJvdW5kcyI6IFsKCQl7CgkJCSJsaXN0ZW4iOiAiMTI3LjAuMC4xIiwKCQkJInBvcnQiOiAxMDk5LAoJCQkicHJvdG9jb2wiOiAic29ja3MiLAoJCQkic2V0dGluZ3MiOiB7fSwKCQkJImRvbWFpbk92ZXJyaWRlIjogWwoJCQkJImh0dHAiLAoJCQkJInRscyIKCQkJXSwKCQkJInRhZyI6ICJkZWZhdWx0SW5ib3VuZCIKCQl9CgldLAoJIm91dGJvdW5kcyI6IFsKCQl7CgkJCSJzZW5kVGhyb3VnaCI6ICJhZGFwdGVySVBBZGRyZXNzIiwKCQkJInByb3RvY29sIjogInZtZXNzIiwKCQkJInNldHRpbmdzIjogewoJCQkJInZuZXh0IjogWwoJCQkJCXsKCQkJCQkJImFkZHJlc3MiOiAidjJyYXlTZXJ2ZXJBZGRyZXNzIiwKCQkJCQkJInBvcnQiOiB2MnJheVNlcnZlclBvcnQsCgkJCQkJCSJ1c2VycyI6IFsKCQkJCQkJCXsKCQkJCQkJCQkiaWQiOiAidjJyYXlVc2VySUQiLAoJCQkJCQkJCSJhbHRlcklkIjogdjJyYXlBbHRlcklELAoJCQkJCQkJCSJzZWN1cml0eSI6ICJhdXRvIgoJCQkJCQkJfQoJCQkJCQldCgkJCQkJfQoJCQkJXQoJCQl9LAoJCQkic3RyZWFtU2V0dGluZ3MiOiB7CgkJCQkibmV0d29yayI6ICJ2MnJheVRyYW5zZmVyTWV0aG9kIiwKCQkJCSJzZWN1cml0eSI6ICJ2MnJheVRMU1NlY3VyZSIsCgkJCQkid3NTZXR0aW5ncyI6IHsKCQkJCQkicGF0aCI6ICJ2MnJheVBhdGgiCgkJCQl9LAoJCQkJImh0dHBTZXR0aW5ncyI6IHsKCQkJCQkicGF0aCI6ICJ2MnJheVBhdGgiCgkJCQl9CgkJCX0sCgkJCSJ0YWciOiAiZGVmYXVsdE91dGJvdW5kIgoJCX0sCgkJewoJCQkic2VuZFRocm91Z2giOiAiYWRhcHRlcklQQWRkcmVzcyIsCgkJCSJwcm90b2NvbCI6ICJmcmVlZG9tIiwKCQkJInNldHRpbmdzIjoge30sCgkJCSJ0YWciOiAiZGlyZWN0T3V0Ym91bmQiCgkJfQoJXQp9";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("请右键选择 以管理员身份运行 ！", "权限错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(1);
            }

            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    MessageBox.Show("缺失重要文件：" + file, "文件缺失", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Environment.Exit(1);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
