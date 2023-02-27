using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Lab.Measurement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
