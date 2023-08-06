namespace SoftwareSpokes.FamilyManager.Api.Services
{
    public class GoogleCalendarServiceWorker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<GoogleCalendarServiceWorker> _logger;

        public GoogleCalendarServiceWorker(
            IServiceProvider serviceProvider,
            ILogger<GoogleCalendarServiceWorker> logger
        )
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(GoogleCalendarServiceWorker)} is starting.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(GoogleCalendarServiceWorker)} is stopping.");
            return base.StopAsync(cancellationToken);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var scope = _serviceProvider.CreateAsyncScope();



            return Task.CompletedTask;
        }
    }
}
