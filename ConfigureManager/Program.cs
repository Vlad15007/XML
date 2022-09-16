using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consumerIp = ConfigurationManager.AppSettings.Get("consumerIp");
            var consumerPort1 = int.Parse(ConfigurationManager.AppSettings.Get("consumerPortCamera1"));
            var consumerPort2 = int.Parse(ConfigurationManager.AppSettings.Get("consumerPortCamera2"));
        }
    }
}
