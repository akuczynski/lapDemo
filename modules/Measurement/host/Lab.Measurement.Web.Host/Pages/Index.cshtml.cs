using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Lab.Measurement.Pages;

public class IndexModel : MeasurementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
