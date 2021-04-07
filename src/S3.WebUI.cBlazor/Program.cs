using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using S3.WebUI.cBlazor.Shared.Config;

namespace S3.WebUI.cBlazor
{
    //public class Program1
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args).Build().Run();
    //    }

    //    public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
    //        BlazorWebAssemblyHost.CreateDefaultBuilder()
    //            .UseBlazorStartup<Startup>();
    //}

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.RegisterShared();

            await builder.Build().RunAsync();
        }
    }
}
