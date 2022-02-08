using AndCultureCodingChallenge.Infrastrcture.Clients;
using AndCultureCodingChallenge.Infrastrcture.Clients.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Repositories;
using AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Services;
using AndCultureCodingChallenge.Infrastrcture.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AndCultureCodingChallenge
{
    public class Startup
    {
        private const string Title = "AndCulture";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen();

            services.AddHttpClient<IBreweriesClient, BreweriesClient>();
            //Register Repositories
            services.AddScoped<IBreweriesRepository, BreweriesRepository>();
            //Register Services
            services.AddScoped<IBreweriesService, BreweriesService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", Title);
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Breweries}/{action=GetBreweries}");
            });
        }
    }
}
