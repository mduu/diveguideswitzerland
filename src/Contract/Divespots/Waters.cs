using DiveGuideSwitzerland.Contracts.SharedModel;

namespace DiveGuideSwitzerland.Contracts.Divespots;

public record Waters(
    WatersId WatersId,
    MultilanguageText Name);