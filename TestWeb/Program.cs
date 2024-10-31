using TestWeb.Data.Interfaces;
using TestWeb.Data.Mocks;

namespace TestWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<IAllItems, MockItem>();
            builder.Services.AddTransient<IItemsCategory, MockCategory>();
            builder.Services.AddMvc();

            var app = builder.Build();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.MapGet("/", () => "Hello!");

            app.Run();
        }
    }
}
