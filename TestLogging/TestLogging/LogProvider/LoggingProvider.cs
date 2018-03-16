
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSCoreLogging.LogProvider
{
    public class LoggingProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private string _connectionString;

        public LoggingProvider(Func<string, LogLevel, bool> filter, string connectionStr)
        {
            _filter = filter;
            _connectionString = connectionStr;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DBLogger(categoryName, _filter, _connectionString);
        }

        public void Dispose()
        {

        }
    }

}
