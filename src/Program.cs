using Friendzone.Http.Middlewares;
using Friendzone.Providers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEmailSender();

builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<Logger>();

app.MapControllers();
app.MapGet("/hello", () => Results.Text("Hello from /hello"));

app.Run();
