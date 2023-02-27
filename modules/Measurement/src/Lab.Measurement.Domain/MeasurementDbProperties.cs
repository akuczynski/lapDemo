namespace Lab.Measurement;

public static class MeasurementDbProperties
{
    public static string DbTablePrefix { get; set; } = "Measurement";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Measurement";
}
