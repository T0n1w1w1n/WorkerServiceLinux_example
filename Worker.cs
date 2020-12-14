using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace worker_test
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker ke 1 running at: {time}", DateTimeOffset.Now);
                doWorker1();
                await Task.Delay(10000, stoppingToken);
            }
        }
        
        private void doWorker1()
        {
            _logger.LogInformation("Function work ke 1");
        }
        
    }
}
