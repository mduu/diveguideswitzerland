using DiveGuideSwitzerland.Contracts.Divespots;
using DiveGuideSwitzerland.Contracts.SharedModel;

namespace Mobile.Features.Divespots.Services;

public interface IDivespotService
{
    Task<IEnumerable<Waters>> GetWaters(bool onlyWithDiveSpots);
    Task<IEnumerable<Divespot>> GetDivespotsForWaters(WatersId watersId);
}