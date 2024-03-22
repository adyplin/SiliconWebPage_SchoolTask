namespace WebApp.Helpers;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseUserSessionValidation(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<UserSessionValidationMiddleware>();
    }
}
