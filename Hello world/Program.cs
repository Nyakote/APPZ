using Hello_world.Services;

namespace Hello_world
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseAuthorization();

          
            app.MapGet("/", () =>
            {
                var greetingService = new GreetingService();
                return Results.Ok(greetingService.GetGreetingMessage());
            });



            app.Run();
        }
    }
}
