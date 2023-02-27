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

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        var mainMenuItem = new ApplicationMenuItem(MeasurementMenus.Prefix, displayName: "Measurement", "/Measurement", icon: "fa fa-globe");
		context.Menu.AddItem(mainMenuItem);

        mainMenuItem.AddItem(new ApplicationMenuItem(MeasurementMenus.Samples,
                displayName: "Samples",
                url: "/Measurement/Samples"
            )).RequirePermissions(MeasurementPermissions.SampleGet);   

        mainMenuItem.AddItem(new ApplicationMenuItem(MeasurementMenus.Example,
        displayName: "Example",
        url: "/Measurement/Example"
    ));

        return Task.CompletedTask;
    }
}
