using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace worker_test
{
    public class Worker2 : BackgroundService
    {
        private readonly ILogger<Worker2> _logger;

        public Worker2(ILogger<Worker2> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker ke 2 running at: {time}", DateTimeOffset.Now);
                doWorker2();
                await Task.Delay(25000, stoppingToken);
            }
        }
        
        private void doWorker2()
        {
            _logger.LogInformation("Function work ke 2");
        }
        
    }
}
