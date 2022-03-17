namespace WebUI.WorkerServices;

public class ConsumeScopedServiceHostedService: BackgroundService
{
    private readonly ILogger<ConsumeScopedServiceHostedService> _logger;
    private IServiceScope ServiceScope { get; }

    public ConsumeScopedServiceHostedService(ILogger<ConsumeScopedServiceHostedService> logger, IServiceProvider services)
    {
        _logger = logger;
        ServiceScope = services.CreateScope();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Consume Scoped Service Hosted Service running");
        await DoWork(stoppingToken);
    }

    private async Task DoWork(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Consume Scoped Service Hosted Service is working");
        // await ServiceScope.ServiceProvider.GetRequiredService<IScopedArticleSyncService>().DoWork(stoppingToken);
        await ServiceScope.ServiceProvider.GetRequiredService<IScopedRoleSeederService>().DoWork(stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            // await ServiceScope.ServiceProvider.GetRequiredService<IScopedClientSyncService>().DoWork(stoppingToken);
            // await ServiceScope.ServiceProvider.GetRequiredService<IScopedClientAddressSyncService>().DoWork(stoppingToken);
            // await ServiceScope.ServiceProvider.GetRequiredService<IScopedClientContactSyncService>().DoWork(stoppingToken);
            // await ServiceScope.ServiceProvider.GetRequiredService<IScopedArticleGroupSyncService>().DoWork(stoppingToken);
            // await ServiceScope.ServiceProvider.GetRequiredService<IScopedArticleSubGroupSyncService>().DoWork(stoppingToken);

            await Task.Delay(TimeSpan.FromMinutes(300), stoppingToken);
        }
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Consume Scoped Service Hosted Service is stopping");
        await base.StopAsync(stoppingToken);
    }
}
