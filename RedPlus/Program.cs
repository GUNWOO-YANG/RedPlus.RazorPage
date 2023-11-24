using RedPlus.Service;

namespace RedPlus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            //�������缭�� start
            builder.Services.AddTransient<PortfoliosServiceJsonFile>();
            //�������缭�� end

            var app = builder.Build();

            //app.MapRazorPages();
            //app.MapGet("/", () => "Hello World!sdfsdf");

            //app.UseStaticFiles();
            app.UseFileServer();
            app.MapRazorPages();
            app.MapBlazorHub();
            app.Run();
        }
        
    }
}