using Serilog;
using Serilog.Core;

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