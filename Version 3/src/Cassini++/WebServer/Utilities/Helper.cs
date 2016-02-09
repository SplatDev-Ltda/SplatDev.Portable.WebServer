using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiW.WebServer.Utilities
{
    public static class Helper
    {
        public static ListenOn ParseListen(string listen)
        {
            return (ListenOn)Enum.Parse(typeof(ListenOn), listen);
        }
        public static string ListenIP(this ListenOn listen)
        {
            switch (listen)
            {
                case ListenOn.Loopback: return "127.0.0.1";
                case ListenOn.Any: return "0.0.0.0";
                default: return "127.0.0.1";
            }
        }
        public static string ToString(this ListenOn listen)
        {
            switch (listen)
            {
                case ListenOn.Loopback: return "Loopback";
                case ListenOn.Any: return "Any";
                default: return "Loopback";
            }
        }
        public static AppType ParseAppType(string type){
            return (AppType)Enum.Parse(typeof(AppType),type);
        }
        public static string AppString(this AppType type)
        {
            switch (type)
            {
                case AppType.WebForms: return "WebForms";
                case AppType.MVC: return "MVC";
                default: return "WebForms";
            }
        }
    }
}
