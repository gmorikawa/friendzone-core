using Friendzone.Http.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<Logger>();

app.MapControllers();
app.MapGet("/hello", () => Results.Text("Hello from /hello"));

app.Run();
