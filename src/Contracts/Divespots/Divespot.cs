using DiveGuideSwitzerland.Contracts.SharedModel;

namespace DiveGuideSwitzerland.Contracts.Divespots;

public record Divespot(
    DivespotId Id,
    WatersId WatersId,
    MultilanguageText Name,
    string City,
    Rating Rating,
    Description Description,
    DivespotCoordinates Coordinates,
    SpecialFeatures SpecialFeatures,
    Images Images,
    DateTimeOffset CreatedTime,
    DateTimeOffset LastModifiedTime,
    bool IsDeleted = false);

public record Rating(
    double AverageRating,
    int CountRatings);

public record Description(
    MultilanguageText Underwater,
    MultilanguageText NonDiving,
    MultilanguageText? Parking,
    MultilanguageText? RestaurantsAndToilets);

public record DivespotCoordinates(
    Coordinates Entry1,
    Coordinates? Entry2,
    Coordinates? Parking,
    Coordinates? Toilets);

public record SpecialFeatures(
    double Fish,
    double Walls,
    double Wrecks,
    double CanyonsAndCaves,
    double Current,
    double NonDiving);

public record Images(
    ImageReference TitleImage,
    ImageReference[]? UnderwaterImages = null,
    ImageReference[]? EntryImages = null,
    ImageReference[]? ParkingImages = null);