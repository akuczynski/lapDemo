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

    public Task<SampleDto> CreateAsync(SampleDto sampleDto)
    {
        return _sampleAppService.CreateAsync(sampleDto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _sampleAppService.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Authorize]
    public async Task<List<SampleDto>> GetListAsync()
    {
        return await _sampleAppService.GetListAsync();
    }
}
