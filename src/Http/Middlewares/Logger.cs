namespace Friendzone.Http.Middlewares;

public class Logger
{
    private readonly RequestDelegate _next;
    private readonly ILogger<Logger> _logger;

    public Logger(RequestDelegate next, ILogger<Logger> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation(
            "Request: {Method} {Path}",
            context.Request.Method,
            context.Request.Path);

        await _next(context);

        _logger.LogInformation(
            "Response: {StatusCode}",
            context.Response.StatusCode);
    }
}
