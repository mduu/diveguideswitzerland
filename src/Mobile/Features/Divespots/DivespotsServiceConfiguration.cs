namespace Mobile.Features.Divespots;

public static class DivespotsServiceConfiguration
{
    public static void AddDivespotsRouting()
    {
        Routing.RegisterRoute(nameof(DivespotsPage), typeof(DivespotsPage));
    }
    
    public static IServiceCollection AddDivespots(this IServiceCollection services)
        => services
            .AddSingleton<DivespotsPage>();
}