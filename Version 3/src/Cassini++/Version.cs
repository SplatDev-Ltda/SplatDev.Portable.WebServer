using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiW
{
    public static class Version
    {
        public static int Major
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.Major; }
        }

        public static int Minor
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.Minor; }
        }

        public static string Product
        {
            get { return GetFromAssemblyAttribute<AssemblyProductAttribute>(x => x.Product); ; }
        }

        public static string FullVersion
        {
            get { return String.Format("{0}.{1}", Major, Minor); }
        }

        public static string FullName
        {
            get { return String.Format("{0} {1}", Product, FullVersion); }
        }

        public static string Copyright
        {
            get 
            {
                return GetFromAssemblyAttribute<AssemblyCopyrightAttribute>(x => x.Copyright);
            }
        }

        public static string Company
        {
            get 
            {
                return GetFromAssemblyAttribute<AssemblyCompanyAttribute>(x => x.Company);
            }
        }

        public static string Description
        {
            get 
            { 
                return GetFromAssemblyAttribute<AssemblyDescriptionAttribute>(x => x.Description);
            }
        }

        private static string GetFromAssemblyAttribute<T>(Func<T, string> extractionFunction)
        {
            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(T), false);
            if (attributes.Length == 0)
            {
                return String.Empty;
            }

            return extractionFunction((T)attributes[0]);
        }
    }
}
