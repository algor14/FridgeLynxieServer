using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxieDatabaseProvider2
{
    public class Logger
    {
        //public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static readonly ILog Log = LogManager.GetLogger("LynxieLogger");
        public Logger()
        {
            //log4net.Config.XmlConfigurator.Configure();
        }
    }
}
