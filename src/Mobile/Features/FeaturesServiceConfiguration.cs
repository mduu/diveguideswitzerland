using Mobile.Features.Divespots;

namespace Mobile.Features;

public static class FeaturesServiceConfiguration
{
    public static void AddFeatureRoutes()
    {
        DivespotsServiceConfiguration.AddDivespotsRouting();
    }
    
    public static IServiceCollection AddFeatures(this IServiceCollection services)
        => services
            .AddDivespots();
}