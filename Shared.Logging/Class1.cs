using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Logging
{
    public class SharedLogging
    {
        public static Logger Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File("log.txt")
            .CreateLogger();
    }
}