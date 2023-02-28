### New ABP project: 
- Create project with ABP CLI 
- Run DbMigrator project 
- Run abp install-libs command on your project folder

### Important information: 
- Starting project is Lab.Blazor 
- Default login admin:1q2w3E*
- Swagger URL: https://localhost:44313/swagger/index.html

### Tutorial: 
- [Web Application Development Tutorial](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=BlazorServer&DB=EF)


### Usefull commands:

- dotnet build /graphBuild - build complete solution (with modules)  
- abp add-module Lab.Instruments --new --add-to-solution-file - create new module with adding it to the solution  


### EF migrations commands (from VS): 
- Add-Migration {MigrationName}
- Update-Database 

<i>Hint 1: Lab.EntityFrameworCore project must be selected in PMC and also in the Solution Exlporer</i> 
<i>Hint 2: To apply migrations run Lab.DbMigrator project</i>

### Samples Apps:
- [EShopOnApp](https://www.eshoponabp.com/) | [Source code](https://github.com/abpframework/eShopOnAbp)
- [EventHub](https://www.openeventhub.com/) | [Source code](https://github.com/abpframework/eventhub)
- [CSP POC - ABP & MAUI](https://f2black.blob.core.windows.net/csp/POC_MAUI_APP.gif)

### Links:
-  [Build simple TODO application in 15 mins](https://youtu.be/Qb-hsf1ID7k)
-  [Add a new Module to the ABP App](https://blog.antosubash.com/posts/abp-add-new-module)
-  [How to Integrate the Telerik Blazor Components to the ABP Blazor UI?](https://community.abp.io/posts/how-to-integrate-the-telerik-blazor-components-to-the-abp-blazor-ui-q8g31abb?_ga=2.152629817.1455784776.1677557058-1202437795.1670611426)


Remarks: 
- HttpApi project can be removed if you don't need Web API/Swagger 
- all projects can be in the single solution 