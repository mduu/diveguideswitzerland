using Mobile.Features;
using Mobile.Features.Divespots;

namespace Mobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        FeaturesServiceConfiguration.AddFeatureRoutes();
    }
}