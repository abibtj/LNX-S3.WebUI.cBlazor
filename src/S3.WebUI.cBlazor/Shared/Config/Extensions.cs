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
using MatBlazor;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.AspNetCore.Components;
using PeterLeslieMorris.Blazor.Validation;

namespace S3.WebUI.cBlazor.Shared.Config
{
    public static class Extensions
    {
        public static IServiceCollection RegisterShared(this IServiceCollection services)
        {
            //services.AddFlexGridServerSide(cfg =>
            //{
            //    cfg.ApplyConfiguration(new SchoolStatisticsGridConfiguration());
            //});
            
            services.AddFlexGrid();
            //services.TryAddScoped(typeof(ILazyDataSetLoader<>), typeof(NullLazyDataSetLoader<>));
            //services.TryAddScoped(typeof(ILazyDataSetItemManipulator<>), typeof(NullLazyDataSetItemManipulator<>));
            //services.TryAddScoped(typeof(ICreateItemHandle<,>), typeof(NullCreateItemHandler<,>));

            services.AddFormValidation(config => config.AddFluentValidation(typeof(Program).Assembly));

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
            services.AddScoped<IRuleService, RuleService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IMiscellaneousService, MiscellaneousService>();

            services.AddMatToaster(config =>
            {
                config.MaximumOpacity = 100;
                config.VisibleStateDuration = 7000;
                config.HideTransitionDuration = 1000;
            });

            return services;
        }

        private static AppSettings GetAppSettings()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("appsettings.json");
            using var reader = new StreamReader(stream);
            return JsonSerializer.Deserialize<AppSettings>(reader.ReadToEnd(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
