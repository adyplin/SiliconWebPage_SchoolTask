using Infrasctructure.Entities;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Helpers;

public class UserSessionValidationMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
    {

    }
}
