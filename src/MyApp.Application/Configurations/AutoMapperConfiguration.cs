using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Mappings.Management;
using MyApp.Application.Mappings.Medical;
using MyApp.Application.Mappings.Music;
using MyApp.Application.Mappings.NPI;

namespace MyApp.Application.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                // Register all AutoMapper profiles here
                cfg.AddProfile(new AlbumProfile());
                cfg.AddProfile(new CDProfile());
                cfg.AddProfile(new TrackProfile());
                cfg.AddProfile(new TaskItemProfile());
                cfg.AddProfile(new ProviderProfile());
                cfg.AddProfile(new ClaimProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
