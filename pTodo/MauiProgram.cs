
#define MAUI

using Microsoft.AspNetCore.Components.Authorization;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;
using pTodo.Services;
using pTodo.Shared.Services;
using Microsoft.FluentUI.AspNetCore.Components;
//using Services;

namespace pTodo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCamera()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Plugin.LocalNotification
            builder.UseLocalNotification();

            // Add device-specific services used by the pTodo.Shared project
            builder.Services.AddScoped<IFormFactor, FormFactor>();

            builder.Services.AddMauiBlazorWebView();

            // Authentication (Microsoft.AspNetCore.Components.Authorization)
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<CustomAuthenticationStateProvider>();
            builder.Services.AddScoped<ICustomAuthenticationStateProvider>(s => s.GetRequiredService<CustomAuthenticationStateProvider>());
            builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<CustomAuthenticationStateProvider>());



            // FluentUI Blazor
            builder.Services.AddFluentUIComponents();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

