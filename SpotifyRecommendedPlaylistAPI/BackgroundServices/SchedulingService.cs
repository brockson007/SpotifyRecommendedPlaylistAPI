using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SpotifyRecommendedPlaylistAPI.BackgroundServices
{
    public class SchedulingService : BackgroundService
    {
        #region Private Fields
        private Serilog.ILogger _logger;
        private readonly IServiceScopeFactory _factory;
        private readonly TimeSpan _timeToWait = TimeSpan.FromDays(7);
        #endregion Private Fields

        public SchedulingService(Serilog.ILogger logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using PeriodicTimer timer = new PeriodicTimer(_timeToWait);
            while(!stoppingToken.IsCancellationRequested && 
                   await timer.WaitForNextTickAsync(stoppingToken))
            {
                try
                {
                    await using AsyncServiceScope asyncScope = _factory.CreateAsyncScope();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Failed to execute SchedulingService with exception message {ex.Message}.");            
                }
            }
        }
    }
}
