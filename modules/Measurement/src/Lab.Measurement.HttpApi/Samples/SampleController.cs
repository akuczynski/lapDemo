using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Lab.Measurement.Samples;

[Area(MeasurementRemoteServiceConsts.ModuleName)]
[RemoteService(Name = MeasurementRemoteServiceConsts.RemoteServiceName)]
[Route("api/Measurement/sample")]
public class SampleController : MeasurementController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpPost]
    [Authorize]
    public Task<SampleDto> CreateAsync(SampleDto sampleDto)
    {
        return _sampleAppService.CreateAsync(sampleDto);
    }

    [HttpDelete]
    [Authorize]
    public async Task DeleteAsync(Guid id)
    {
        await _sampleAppService.DeleteAsync(id);
    }

    [HttpGet]
    [Route("list")]
    [Authorize]
    public async Task<List<SampleDto>> GetListAsync()
    {
        return await _sampleAppService.GetListAsync();
    }
}
