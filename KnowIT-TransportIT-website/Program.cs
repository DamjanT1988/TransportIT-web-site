using KnowIT_TransportIT_website;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

//create the builder
var builder = WebAssemblyHostBuilder.CreateDefault(args);

//build the app component
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//initailize http client service
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//wait and run app
await builder.Build().RunAsync();