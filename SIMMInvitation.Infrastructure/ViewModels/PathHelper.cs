using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace SIMMInvitation.Infrastructure.ViewModels
{
    public class PathHelper
    {
        public static string vRoot { get; set; }
        public static string HostName { get; set; }
        public static string Root { get; set; }
        public static string MTitle { get; set; }

        static PathHelper()
        {
            vRoot = ConfigurationManager.AppSettings["vRoot"];
            HostName = ConfigurationManager.AppSettings["HostName"];
            Root = ConfigurationManager.AppSettings["Root"];
            MTitle = ConfigurationManager.AppSettings["MTitle"];
        }
    }
}
