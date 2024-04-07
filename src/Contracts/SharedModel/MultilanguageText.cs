namespace DiveGuideSwitzerland.Contracts.SharedModel;

public record MultilanguageText(
    string Default,
    string? EN = null,
    string? DE = null,
    string? FR = null,
    string? IT = null);