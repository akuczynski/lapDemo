namespace Lab.Instruments;

public static class InstrumentsDbProperties
{
    public static string DbTablePrefix { get; set; } = "Instruments";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Instruments";
}
