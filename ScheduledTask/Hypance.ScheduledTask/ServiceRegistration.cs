using Microsoft.Extensions.DependencyInjection;
namespace Hypance.ScheduledTask
{
    public static class ServiceRegistration
    {
        public static void AddScheduledTaskServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<SignalControlTask>();
            serviceCollection.AddHostedService<SignalControlTask>();

        }
    }
}
