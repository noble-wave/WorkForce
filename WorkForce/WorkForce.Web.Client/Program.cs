using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WorkForce.Shared.Services;
using WorkForce.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the WorkForce.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
