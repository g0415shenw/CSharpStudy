using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarStudy
{
    public class LogHelp
    {
        public static readonly ILogger logger = LogManager.GetLogger("Logger");
    }
}
