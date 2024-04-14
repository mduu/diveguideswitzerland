using CommunityToolkit.Mvvm.ComponentModel;
using DiveGuideSwitzerland.Contracts.Divespots;
using Mobile.Features.Divespots.Services;

namespace Mobile.Features.Divespots;

public partial class DivespotsPageViewModel : ObservableObject
{
    private readonly IDivespotService divespotService;

    [ObservableProperty] private List<Waters> waters = new();

    public DivespotsPageViewModel(IDivespotService divespotService)
    {
        this.divespotService = divespotService;

        LoadWaters();
    }

    private void LoadWaters()
    {
        divespotService.GetWaters(false).ContinueWith(
            t => Waters = !t.IsFaulted
                ? t.Result
                    .OrderBy(w => w.Name.Default)
                    .ToList()
                : []);
    }

    // [RelayCommand]
    // public async Task ShowInfoBasicDesign()
    // {
    //     await Shell.Current.DisplayAlert(
    //         "Info on Basic Design",
    //         "Basics data to calculate the design and glide-/sink polars using sweep T/4=0.",
    //         "Close");
    // }
}