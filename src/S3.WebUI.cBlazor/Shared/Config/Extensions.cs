using System.IO;
using System.Reflection;
using System.Text.Json;
using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using Blazor.FlexGrid;
using Blazor.FlexGrid.DataSet;
using Blazor.FlexGrid.DataSet.Http;
using S3.WebUI.cBlazor.Models.GridDisplayConfigurations;
using S3.WebUI.cBlazor.Utility;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.AspNetCore.Components;

namespace S3.WebUI.cBlazor.Shared.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterShared(this IServiceCollection services)
        {
            services.AddFlexGridServerSide(cfg =>
            {
                cfg.ApplyConfiguration(new SchoolStatisticsGridConfiguration());
            });
            services.TryAddScoped(typeof(ILazyDataSetLoader<>), typeof(NullLazyDataSetLoader<>));
            services.TryAddScoped(typeof(ILazyDataSetItemManipulator<>), typeof(NullLazyDataSetItemManipulator<>));
            services.TryAddScoped(typeof(ICreateItemHandle<,>), typeof(NullCreateItemHandler<,>));

            services.AddBlazoredLocalStorage();
            services.AddSingleton(GetAppSettings());
            services.AddScoped<AppUser>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<IStudentScoreService, StudentScoreService>();
            services.AddScoped<IScoresEntryTaskService, ScoresEntryTaskService>();
            services.AddScoped<IClassSubjectScoresService, ClassSubjectScoresService>();
            services.AddScoped<IMiscellaneousService, MiscellaneousService>();

            return services;
        }

        public static void AddEnvironmentConfiguration<TResource>(this IServiceCollection services, Func<EnvironmentChooser> environmentChooserFactory)
        {
            services.AddSingleton<IConfiguration>((s) =>
            {
                var environementChooser = environmentChooserFactory();
                //var uri = new Uri("test");
                var uri = new Uri(s.GetRequiredService<NavigationManager>().Uri);
                Assembly assembly = typeof(TResource).Assembly;
                string environment = environementChooser.GetCurrent(uri);
                var ressourceNames = new[]
                {
                    assembly.GetName().Name + ".Configuration.appsettings.json",
                    assembly.GetName().Name + ".Configuration.appsettings." + environment + ".json"
                };
                
                ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddInMemoryCollection(new Dictionary<string, string>()
                {
                    { "Environment", environment }       
                });
                
                Console.WriteLine(string.Join(",", assembly.GetManifestResourceNames()));
                Console.WriteLine(string.Join(",", ressourceNames));
                foreach (var resource in ressourceNames)
                {

                    if (assembly.GetManifestResourceNames().Contains(resource))
                    {
                        configurationBuilder.AddJsonFile(
                            new InMemoryFileProvider(assembly.GetManifestResourceStream(resource)), resource, false, false);
                    }
                }
                return configurationBuilder.Build();
            });
        }

        private static AppSettings GetAppSettings()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("appsettings.json");
            using var reader = new StreamReader(stream);
            return JsonSerializer.Deserialize<AppSettings>(reader.ReadToEnd(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
