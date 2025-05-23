using KristofferStrube.Blazor.Popper;
using KristofferStrube.Blazor.Relewise.WasmExample;
using KristofferStrube.Blazor.Relewise.XmlSummaries;
using KristofferStrube.Blazor.Window;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

AppContext.SetSwitch("System.Reflection.NullabilityInfoContext.IsSupported", true);

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<Popper>();
builder.Services.AddScoped<NugetClient>();
builder.Services.AddSingleton<DocumentationCache>();
builder.Services.AddWindowService();
builder.Services.AddScoped<IJSInProcessRuntime>(sp => (IJSInProcessRuntime)sp.GetRequiredService<IJSRuntime>());

await builder.Build().RunAsync();
