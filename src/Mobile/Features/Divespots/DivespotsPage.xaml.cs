namespace Mobile.Features.Divespots;

public partial class DivespotsPage : ContentPage
{
    public DivespotsPage(DivespotsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}