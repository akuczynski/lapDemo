using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Lab.Measurement.Samples;

public class SampleAppService_Tests : MeasurementApplicationTestBase
{
    private readonly ISampleAppService _sampleAppService;

    public SampleAppService_Tests()
    {
        _sampleAppService = GetRequiredService<ISampleAppService>();
    }

    //[Fact]
    //public async Task GetAsync()
    //{
    //    var result = await _sampleAppService.GetAsync();
    //    result.ShouldNotBeNull();
    //}

    //[Fact]
    //public async Task GetAuthorizedAsync()
    //{
    //    var result = await _sampleAppService.GetAuthorizedAsync();
    //    result.ShouldNotBeNull();
    //}
}
