using HomeWork2.Realizations;
using HW2.Interfaces;
using HW2.Realizations;

namespace HomeWork2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<IManagementCars, ManagementCars>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            //MAP
            app.Map("/model", ModelHandle);
            app.Map("/year", AgeHandle);
            app.Map("/engine", EngineHandle);
            app.Map("/modelMiddleware", ModelHandleMiddleware);
            app.Map("/yearMiddleware", AgeHandleMiddleware);
            app.Map("/engineMiddleware", EngineHandleMiddleware);


            app.Run(async context =>
            {
                var carManager = app.Services.GetService<IManagementCars>();
                await context.Response.WriteAsync($"Car model: {carManager?.GetCarName()}\n");
                await context.Response.WriteAsync($"Car year: {carManager?.GetCarAge()}\n");
                await context.Response.WriteAsync($"Car engine: {carManager.GetCarEngine()}\n");
            });

            app.Run();
        }

        private static void ModelHandle(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var carManager = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync($"Car model: {carManager?.GetCarName()}\n");
            });
        }
        private static void AgeHandle(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var carManager = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync($"Car model: {carManager?.GetCarAge()}\n");
            });
        }
        private static void EngineHandle(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var carManager = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync($"Car model: {carManager?.GetCarEngine()}\n");
            });
        }

        private static void ModelHandleMiddleware(IApplicationBuilder app)
        {
            app.UseMiddleware<ManagementCarsNameMiddleware>();
        }
        private static void AgeHandleMiddleware(IApplicationBuilder app)
        {
            app.UseMiddleware<ManagementCarsAgeMiddleware>();
        }
        private static void EngineHandleMiddleware(IApplicationBuilder app)
        {
            app.UseMiddleware<ManagementCarsEngineMiddleware>();
        }
    }
}