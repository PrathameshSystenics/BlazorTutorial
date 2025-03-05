using BlazorTutorial.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<FilledTodos>();
await builder.Build().RunAsync();
