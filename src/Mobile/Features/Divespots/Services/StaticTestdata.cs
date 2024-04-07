using DiveGuideSwitzerland.Contracts.Divespots;
using DiveGuideSwitzerland.Contracts.SharedModel;

namespace Mobile.Features.Divespots.Services;

internal static class StaticTestdata
{
    public static readonly WatersId WatersIdZuerichsee = new(new("BE726179-86E9-4302-A3F8-D63F1E4D8FD3"));
    public static readonly WatersId WatersIdZugersee = new(new("FF8DEF94-144F-48E9-9853-9E46FB222516"));
    public static readonly WatersId WatersIdBodensee = new(new("CA78A179-EDEC-49D6-9B04-5BB1516A3750"));
    public static readonly WatersId WatersIdRhein = new(new("3D79918F-148B-45D3-A7D9-FA7A574F661C"));
    public static readonly WatersId WatersIdVwss = new(new("746BDA2C-E32E-4DAC-A3AF-14580D27CA9C"));
    public static readonly WatersId WatersIdThunersee = new(new("AC9024E8-7C6B-484D-9A44-097B3D05CA47"));
    public static readonly WatersId WatersIdVerzasca = new(new("37DF5455-8A92-4ABA-9856-45F966F86FE9"));
    public static readonly WatersId WatersIdWalenensee = new(new("558FD452-A0B0-4BBE-B2D9-8CD4AA34C195"));
    public static readonly WatersId WatersIdMaggia = new(new("A106CA1E-980F-468D-8888-F72855F8E8CC"));

    public static readonly Waters[] Waters =
    [
        new(WatersIdZuerichsee, new("Zürichsee")),
        new(WatersIdZugersee, new("Zugersee")),
        new(WatersIdBodensee, new("Bodensee")),
        new(WatersIdRhein, new("Rhein")),
        new(WatersIdVwss, new("Vierwaldstättersee")),
        new(WatersIdThunersee, new("Thunersee")),
        new(WatersIdVerzasca, new("Verzasca")),
        new(WatersIdWalenensee, new("Walensee")),
        new(WatersIdMaggia, new("Maggia"))
    ];

    public static Divespot[] Divespots =>
    [
        ZhTerlinden,
        ZgBaumgaertli,
    ];

    private static readonly Divespot ZhTerlinden = new(
        new(new("FA080475-CC59-4D9B-AD18-24F3C84B3A7F")),
        WatersIdZuerichsee,
        new("Terlinden"),
        "Küsnacht ZH",
        new(5, 1),
        new(
            new("Flacher abhang bis ca. 30m Tiefe. Ab 30-42 Steilwand stellenweise mit grossem Überhang und Spalten. Von ca. 46-52m eine zweite Steilwand. Es kann sowohl Richtung Zürich wie auch Richtung Rapperswil getaucht werden. Richtung Zürich gibt es auf ca. 40m einie Gartenzwerge. Richtung Rapperswil ist es tiefer. Achtung: nicht in den Hafen tauchen!"),
            new("Schöne Badeweise mit Steg der auch zum Baden einlädt."),
            new("Diverse Parkplätze direkt beim Tauchplatz und der Strasse entlang. Bei schönem Wetter aber trotzdem oft besetzt."),
            new("Öffentliche Toiletten ca. 50m weiter Richtung Rapperswil. Da gibt es auch einen kleinen Imbiss. Manchmal 'Güggeliwagen' am TP.")),
        new(
            new(47.32891, 8.57281),
            null,
            new(47.32895, 8.57306),
            new(47.32824, 8.57317)),
        new(
            4,
            5,
            2,
            3,
            1,
            4),
        new(
            new(
                "https://tauchfotos.files.wordpress.com/2023/05/dsc_0046.jpg?w=4000&h=",
                "Marc Dürst"),
            new[]
            {
                new ImageReference(
                    "https://tauchfotos.files.wordpress.com/2023/05/dsc_0048.jpg?w=4000&h=",
                    "Marc Dürst"),
            }),
        new(2024, 4, 7, 17, 12, 0, TimeSpan.FromHours(2)),
        new(2024, 4, 7, 17, 12, 0, TimeSpan.FromHours(2)));

    private static readonly Divespot ZgBaumgaertli = new(
        new(new("3BA608EF-0166-4F14-B8B8-39DD4920BBA1")),
        WatersIdZugersee,
        new("Baumgärtli"),
        "Immensee",
        new(4, 1),
        new(
            new("Nach dem Einsteig abfallend. Richtung Immensee tauchen. Man komm dort an mehrere Wände/Absätze die in die Tiefe verlaufen. Es gibt auch Bäume unterwasser."),
            new("Spaziermöglichkeiten direkt ab Parkplatz. Beim Einstieg kann auch gut gebadet werden."),
            new("Diverse Parkplätze direkt beim Tauchplatz. Gebührenpflichtig."),
            new("Es hat ein ToiToi beim Parkplatz und ein paar Meter weiter das Restaurant welches sehr Taucher-freundlich ist.")),
        new(
            new(47.10494, 8.47552),
            null,
            new(47.10494, 8.47538),
            new(47.10541, 8.47538)),
        new(
            4,
            4,
            0,
            0,
            1,
            3),
        new(
            new(
                "https://tauchfotos.files.wordpress.com/2023/10/img_7307.jpg?w=4000&h=",
                "Marc Dürst"),
            new[]
            {
                new ImageReference(
                    "https://tauchfotos.files.wordpress.com/2023/10/dsc_0021-1.jpg?w=4000&h=",
                    "Marc Dürst"),
            }),
        new(2024, 4, 7, 17, 12, 0, TimeSpan.FromHours(2)),
        new(2024, 4, 7, 17, 12, 0, TimeSpan.FromHours(2)));
}