using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;

namespace ChannelEngine.Common
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILogger<LoggingInterceptor> _logger;
        public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            _logger.LogDebug($"METHOD CALL STAR. METHOD NAME : {0}", invocation.Method.Name);

            DateTime startTime = DateTime.UtcNow;

            invocation.Proceed();

            DateTime endTime = DateTime.UtcNow;

            _logger.LogDebug($"METHOD CALL END. METHOD NAME : {0}", invocation.Method.Name);
            _logger.LogDebug("METHOD Executed in {0} ", (endTime - startTime).TotalMilliseconds);
        }
    }
}
