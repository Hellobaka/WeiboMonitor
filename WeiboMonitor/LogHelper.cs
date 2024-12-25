using System;

namespace WeiboMonitor
{
    public static class LogHelper
    {
        public static Action<string, string, bool> InfoMethod = null;
        public static void Info(string type, string message, bool status = true)
        {
            if (InfoMethod == null)
            {
                Console.WriteLine($"{(status ? "[+]" : "[-]")}[{DateTime.Now:G}][{type}]{message}");
            }
            else
            {
                InfoMethod.Invoke(type, message, status);
            }
        }
    }
}
