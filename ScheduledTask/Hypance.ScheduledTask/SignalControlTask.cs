using Hypance.Services.TelegramApi;
using Microsoft.Extensions.Hosting;

namespace Hypance.ScheduledTask;

public class SignalControlTask : BackgroundService
{
    /*private readonly IRepository<Signal> _signalRepository;
    private readonly IRepository<IndicatorSignal> _indicatorSignal;
    public SignalControlTask( IRepository<Signal> signalRepository, IRepository<IndicatorSignal> indicatorSignal)
    {
        _signalRepository = signalRepository;
        _indicatorSignal = indicatorSignal;
    }
    */
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromDays(1));

        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
           // var LastSignal = _indicatorSignal.Get(x=>x.IsActive);
            //var ClientSignal= _signalRepository.Get(x=>x.Name=="RSI");

            //if (LastSignal.Signals[0] == ClientSignal.Period)
            //{
                TelegramApiConfig.SendMessage("RSI botu istenilen seviyede");
            // }

        }
    }
}