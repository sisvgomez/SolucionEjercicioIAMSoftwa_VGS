using BlazorAppCrud;
using BlazorAppCrud.Helpers;
using BlazorAppCrud.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
              .AddScoped<IClienteService, ClienteService>()
              .AddScoped<IAlertService, AlertService>()
              .AddScoped<IHttpService, HttpService>();


builder.Services.AddScoped(x => {
    var apiUrl = new Uri(builder.Configuration["apiUrl"]);

    return new HttpClient() { BaseAddress = apiUrl };
});

var host = builder.Build();

var customerService = host.Services.GetRequiredService<IClienteService>();


await host.RunAsync();
