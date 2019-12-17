using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using S3.WebUI.cBlazor.Areas.Students.Config;
using S3.WebUI.cBlazor.Shared.Config;
using PeterLeslieMorris.Blazor.Validation;
using Blazor.FlexGrid;
using S3.WebUI.cBlazor.Utility;
using System.IO;
//using Microsoft.AspNetCore.Hosting;
//using DinkToPdf.Contracts;
//using DinkToPdf;
//using RazorLight;
using System.Reflection;
using Blazor.FlexGrid.DataSet;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Blazor.FlexGrid.DataSet.Http;

namespace S3.WebUI.cBlazor
{
    public class Startup
    {
	//public IWebHostEnvironment HostingEnvironment { get; }
 //       public Startup(IWebHostEnvironment environment)
 //       {
 //           HostingEnvironment = environment;
 //       }

        //public Startup(IHostingEnvironment environment)
        //{
        //    //Configuration = configuration;
        //    HostingEnvironment = environment;
        //}

        //public IHostingEnvironment HostingEnvironment { get; }
        ////public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
	    services.AddFlexGrid();
            //services.AddRazorPages();
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

            services.TryAddScoped(typeof(ILazyDataSetLoader<>), typeof(NullLazyDataSetLoader<>));
            services.TryAddScoped(typeof(ILazyDataSetItemManipulator<>), typeof(NullLazyDataSetItemManipulator<>));
            services.TryAddScoped(typeof(ICreateItemHandle<,>), typeof(NullCreateItemHandler<,>));

            //// Load unmanaged library for converting HTML to PDF (DinkToPdf)
            //var architectureFolder = (Environment.Is64BitProcess && IntPtr.Size == 8) ? "64 bit" : "32 bit";
            ////var dinkToPdfPath = Path.Combine(HostingEnvironment.ContentRootPath, $"DinkToPdf\\v0.12.4\\{architectureFolder}\\libwkhtmltox");
            //var dinkToPdfPath = Path.Combine(Directory.GetCurrentDirectory(), $"DinkToPdf\\v0.12.4\\{architectureFolder}\\libwkhtmltox");
            //CustomAssemblyLoadContext customContext = new CustomAssemblyLoadContext();
            //customContext.LoadUnmanagedLibrary(dinkToPdfPath);

            //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools())); // Register DinkToPdf converter (converts from html to pdf)

            //// Register RazorLight (RazorLight is a powerful library for templating HTML documents and has lots of features for rendering HTML content)
            //services.AddScoped<IRazorLightEngine>(sp =>
            //{
            //    var engine = new RazorLightEngineBuilder()
            //        .UseFilesystemProject(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
            //        .UseMemoryCachingProvider()
            //        .Build();
            //    return engine;
            //});
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            //force config initialisation with current uri
            IConfiguration config = app.Services.GetService<IConfiguration>();

	    //app.UseFlexGrid(HostingEnvironment.WebRootPath);
            app.AddComponent<App>("app");
        }
    }
}
