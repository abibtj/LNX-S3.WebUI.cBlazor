using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;
//using EmbeddedBlazorContent;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using S3.WebUI.cBlazor.Areas.Students.Config;
using S3.WebUI.cBlazor.Shared.Config;
using PeterLeslieMorris.Blazor.Validation;
using Blazor.FlexGrid;
using S3.WebUI.cBlazor.Utility;

namespace S3.WebUI.cBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEnvironmentConfiguration<Startup>(() =>
            new EnvironmentChooser("Development")
                .Add("localhost", "Development")
                .Add("xyz.com", "Production", false));

            services.AddFormValidation(config => config.AddFluentValidation(typeof(Startup).Assembly));
            //services.AddSingleton<HttpClient>(); /// Not needed in client side model
            services.RegisterShared();

            services.AddMatToaster(config =>
            {
                config.MaximumOpacity = 100;
                config.VisibleStateDuration = 7000;
                config.HideTransitionDuration = 1000;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            //force config initialisation with current uri
            IConfiguration config = app.Services.GetService<IConfiguration>();

            app.AddComponent<App>("app");
        }
    }
}
