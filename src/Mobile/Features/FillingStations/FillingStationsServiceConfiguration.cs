namespace Mobile.Features.FillingStations;

public static class FillingStationsServiceConfiguration
{
    public static void AddFillingStationsRouting()
    {
        Routing.RegisterRoute(nameof(FillingStationPage), typeof(FillingStationPage));
    }
    
    public static IServiceCollection AddFillingStations(this IServiceCollection services)
        => services
            .AddSingleton<FillingStationPage>();
}