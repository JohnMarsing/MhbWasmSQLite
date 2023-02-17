using MhbWasmSQLite.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MhbWasmSQLite.Client.Services;
using Fluxor;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IScriptureService, ScriptureService>();
builder.Services.AddBlazoredToast();
builder.Services.AddFluxor(o =>
{
	o.ScanAssemblies(typeof(Program).Assembly);  // typeof(Startup)
#if DEBUG
	o.UseReduxDevTools();
#endif
});

await builder.Build().RunAsync();
