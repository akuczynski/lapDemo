using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lab.Instruments.Blazor.Menus;

public class InstrumentsMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(InstrumentsMenus.Prefix, displayName: "Instruments", "/Instruments", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
