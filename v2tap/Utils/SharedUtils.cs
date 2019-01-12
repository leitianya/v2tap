using System.Diagnostics;

namespace v2tap.Utils
{
    public static class SharedUtils
    {
        public static void ExecuteCommand(string text)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + text;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
        }
    }
}
