using Mobile.Features.Divespots;
using Mobile.Features.FillingStations;

namespace Mobile.Features;

public static class FeaturesServiceConfiguration
{
    public static void AddFeatureRoutes()
    {
        DivespotsServiceConfiguration.AddDivespotsRouting();
        FillingStationsServiceConfiguration.AddFillingStationsRouting();
    }

    public static IServiceCollection AddFeatures(this IServiceCollection services)
        => services
            .AddDivespots()
            .AddFillingStations();
}