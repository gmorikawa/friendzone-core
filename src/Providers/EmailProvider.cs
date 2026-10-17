namespace Friendzone.Providers;

public static class EmailProvider
{
    public static IServiceCollection AddEmailSender(this IServiceCollection services)
    {
        services.AddScoped(serviceProvider =>
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var smtp = configuration.GetSection("Email:Smtp");

            return new Core.Email.Sender(
                endpoint: new Core.Email.Endpoint(
                    host: smtp["Host"] ?? "",
                    port: smtp.GetValue("Port", 465)
                ),
                credentials: new Core.Email.Credentials(
                    username: smtp["Username"] ?? "",
                    password: smtp["Password"] ?? ""
                ),
                enableSsl: smtp.GetValue<bool>("EnableTsl")
            );
        });

        return services;
    }
}
