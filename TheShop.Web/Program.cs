using TheShop.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TheShop.Web.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IEmployee, EmployeeDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44379/");
});

builder.Services.AddHttpClient<ICountry, CountryDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44379/");
});

builder.Services.AddHttpClient<IJob, JobCategoryDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44379/");
});
await builder.Build().RunAsync();
