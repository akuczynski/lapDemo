using System;

namespace Lab.Measurement.Samples;

public class SampleDto
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public int Value { get; set; }

    public string Measurement { get; set; }

    public override string ToString()
    {
        return $"{Measurement}: Nr {Number} has value : {Value}";
    }
}
