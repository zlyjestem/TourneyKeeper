using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TK.Tournaments.WebAPI;
using TK.Tournaments.WebAPI.Entities;
using TK.Tournaments.WebAPI.Models;
using TK.Tournaments.WebAPI.Services;
using TourneyKeeper.Entities;

namespace TourneyKeeper
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public static IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                    new XmlDataContractSerializerOutputFormatter()));

            var connectionString = Startup.Configuration["connectionStrings:tourneyKeeperDBConnectionString"];
            services.AddDbContext<TourneyKeeperContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<ITournamentKeeperRepository, TournamentKeeperRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, TourneyKeeperContext tourneyKeeperContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseCors(builder =>
                builder.WithOrigins("http://localhost:3000").AllowAnyHeader());

            tourneyKeeperContext.EnsureSeedDataForContext();
            app.UseStatusCodePages();
            AutoMapper.Mapper.Initialize(cfg => { cfg.CreateMap<Tournament, TournamentDto>(); });
            app.UseMvc();
        }
    }
}
