using System;
using System.Diagnostics;

namespace Cassinipp.HttpMonitor
{
    public static class HttpMon
    {
        private const string BytesSent = "bytes sent: {0}k\tbytes received: {1}k";
        private static PerformanceCounterCategory performanceCounterCategory;
        private static PerformanceCounter performanceCounterSent;
        private static PerformanceCounter performanceCounterReceived;
        private static string instance = string.Empty;

        /// <summary>
        /// Shows the networktraffic.
        /// </summary>
        public static string ShowNetworkTraffic(int eth = 0)
        {
            SetVariables(eth);
            return string.Format(BytesSent, performanceCounterSent.NextValue() / 1024, performanceCounterReceived.NextValue() / 1024);
        }

        public static float BytesIn(int eth = 0)
        {
            SetVariables(eth);
            return performanceCounterReceived.NextValue() / 1024;
        }
        public static float BytesOut(int eth = 0)
        {
            SetVariables(eth);
            return performanceCounterSent.NextValue() / 1024;
        }

        private static void SetVariables(int eth = 0)
        {
            performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            instance = performanceCounterCategory.GetInstanceNames()[eth]; // 1st NIC !
            performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);
        }
    }
}
