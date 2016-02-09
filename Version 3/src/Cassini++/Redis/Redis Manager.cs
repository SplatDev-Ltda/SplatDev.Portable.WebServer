using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PiW.Redis
{
    public class Redis_Manager
    {
        private Process redis;
        public Process Redis { get { return redis; } }
        private bool online = false;
        public bool Online { get { return online; } set { online = value; } }
        private static string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private const string BIN = @"\Resources\Bin\";

        public void Start(bool showPanel)
        {
            redis.StartInfo.WindowStyle = showPanel ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            redis.Start();

        }
        public void Stop()
        {
            if (!redis.HasExited)
            {
                redis.Kill();
                online = false;
            }
        }
        public Redis_Manager()
        {
            redis = new Process();
            redis.StartInfo.WorkingDirectory = dir + BIN;
            redis.StartInfo.FileName = "redis-server.exe";
            redis.StartInfo.Arguments = "redis.conf"; // commandline params
            redis.EnableRaisingEvents = true;//allow to return events - for starting and killing
        }
        public static void OpenConsole()
        {
            Process console = new Process();
            console.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            console.StartInfo.WorkingDirectory = dir + BIN;
            console.StartInfo.FileName = "redis-cli.exe";
            console.Start();
        }
        public static void OpenBenchmark()
        {
            Process benchmark = new Process();
            benchmark.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            benchmark.StartInfo.WorkingDirectory = dir + BIN;
            benchmark.StartInfo.FileName = "redis-benchmark.exe";
            benchmark.Start();
        }
        public static void OpenConfig()
        {
            string configpath = dir + BIN + "redis.conf";
            Process.Start(@"notepad.exe", configpath);
        }
    }
}
