//using Microsoft.AspNetCore.Components.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using MatBlazor;
//using Microsoft.Extensions.Configuration;
//using S3.WebUI.cBlazor.Shared.Config;
//using PeterLeslieMorris.Blazor.Validation;
//using Blazor.FlexGrid;
//using S3.WebUI.cBlazor.Utility;
//using System.IO;
//using System.Reflection;
//using Blazor.FlexGrid.DataSet;
//using Microsoft.Extensions.DependencyInjection.Extensions;
//using Blazor.FlexGrid.DataSet.Http;

//namespace S3.WebUI.cBlazor
//{
//    public class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddFlexGrid();
//            services.AddEnvironmentConfiguration<Startup>(() =>
//            new EnvironmentChooser("Development")
//                .Add("localhost", "Development")
//                .Add("xyz.com", "Production", false));

//            services.AddFormValidation(config => config.AddFluentValidation(typeof(Startup).Assembly));
//            //services.AddSingleton<HttpClient>(); /// Not needed in client side model
//            services.RegisterShared();

//            services.AddMatToaster(config =>
//            {
//                config.MaximumOpacity = 100;
//                config.VisibleStateDuration = 7000;
//                config.HideTransitionDuration = 1000;
//            });

//            services.TryAddScoped(typeof(ILazyDataSetLoader<>), typeof(NullLazyDataSetLoader<>));
//            services.TryAddScoped(typeof(ILazyDataSetItemManipulator<>), typeof(NullLazyDataSetItemManipulator<>));
//            services.TryAddScoped(typeof(ICreateItemHandle<,>), typeof(NullCreateItemHandler<,>));
//        }

//        public void Configure(IComponentsApplicationBuilder app)
//        {
//            //force config initialisation with current uri
//            IConfiguration config = app.Services.GetService<IConfiguration>();

//            app.AddComponent<App>("app");
//        }
//    }
//}
