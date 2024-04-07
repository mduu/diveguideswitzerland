using Mobile.Features.Divespots.Services;

namespace Mobile.Features.Divespots;

public static class DivespotsServiceConfiguration
{
    public static void AddDivespotsRouting()
    {
        Routing.RegisterRoute(nameof(DivespotsPage), typeof(DivespotsPage));
    }

    public static IServiceCollection AddDivespots(this IServiceCollection services)
        => services
            .AddDivespotServices()
            .AddDivespotPages();

    private static IServiceCollection AddDivespotServices(this IServiceCollection services)
        => services
            .AddSingleton<IDivespotService, StaticDivespotService>();

    private static IServiceCollection AddDivespotPages(this IServiceCollection services)
        => services
            .AddSingleton<DivespotsPage>();
}