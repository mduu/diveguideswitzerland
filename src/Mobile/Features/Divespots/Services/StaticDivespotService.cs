using DiveGuideSwitzerland.Contracts.Divespots;
using DiveGuideSwitzerland.Contracts.SharedModel;

namespace Mobile.Features.Divespots.Services;

internal class StaticDivespotService : IDivespotService
{
    public Task<IEnumerable<Waters>> GetWaters(bool onlyWithDiveSpots)
        => Task.FromResult(
            StaticTestdata.Waters
                .Where(w =>
                    StaticTestdata.Divespots.Any(d => d.WatersId.Id == w.WatersId.Id)));

    public Task<IEnumerable<Divespot>> GetDivespotsForWaters(WatersId watersId)
        => Task.FromResult<IEnumerable<Divespot>>(
            StaticTestdata.Divespots
                .Where(d => d.WatersId.Id == watersId.Id)
                .OrderBy(d => d.Name.Default));
}