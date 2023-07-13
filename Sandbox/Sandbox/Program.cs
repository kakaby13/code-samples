using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sandbox.Services;

CreateHost()
    .Build()
    .Services
    .GetService<AppRunner>()!
    .Do();

IHostBuilder CreateHost()
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddTransient<AppRunner>(); // каждый раз новый AppRunner
            services.AddScoped<IFoodProvider, AnotherFoodProvider>(); // по 1 штуке на инстанс
            services.AddSingleton<AnimalFeeder>(); // один раз на всю прилагу
        });
}