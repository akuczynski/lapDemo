using Lab.Measurement.Localization;
using Lab.Measurement.Permissions;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;

namespace Lab.Measurement.Blazor.Menus;

public class MeasurementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<MeasurementResource>();

        //Add main menu items.
        var rootMenuItem = new ApplicationMenuItem(MeasurementMenus.Prefix, displayName: "Measurement", "/Measurement", icon: "fa fa-globe");
        context.Menu.AddItem(rootMenuItem);

        if (await context.IsGrantedAsync(MeasurementPermissions.Samples.Default))
        { 
            rootMenuItem.AddItem(new ApplicationMenuItem(
              name: MeasurementMenus.Samples,
              displayName: l["Menu:Samples"],
              url: "/Measurement/Samples"
          ));
        }

        rootMenuItem.AddItem(new ApplicationMenuItem(
            name: MeasurementMenus.Example,
            displayName: l["Menu:Example"],
            url: "/Measurement/Example"
        ));
    }
}
