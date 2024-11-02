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

            // ¬казуЇмо маршрути
            app.MapGet("/", () =>
            {
                var greetings = "Hello world";
                var name = "I'm Nevmivaka Dmitriy Andriyovich PR-3-2";
                var responseTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return Results.Content($"{greetings}<br />{name}<br />Execution time {responseTime}", "text/html");
            });



            app.MapGet("/greet/{name}", (string name) =>
            {
                return Results.Ok($"Hello, {name}!");
            });

            app.Run();
        }
    }
}