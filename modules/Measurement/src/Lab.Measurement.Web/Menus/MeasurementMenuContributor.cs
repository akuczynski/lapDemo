using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lab.Measurement.Web.Menus;

public class MeasurementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(MeasurementMenus.Prefix, displayName: "Measurement", "~/Measurement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
