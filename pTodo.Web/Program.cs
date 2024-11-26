#define WEB

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.FluentUI.AspNetCore.Components;
using pTodo.Shared.Services;
using pTodo.Web.Components;
using pTodo.Web.Services;
using System.Security.Claims;
using web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<AuthenticationStateProvider, web.CookieAuthStateProvider>();

// Add device-specific services used by the pTodo.Shared project
builder.Services.AddScoped<IFormFactor, FormFactor>();

// FluentUI Blazor
builder.Services.AddHttpClient();
builder.Services.AddFluentUIComponents();

// Authentication (Microsoft.AspNetCore.Components.Authorization)
builder.Services.AddScoped<CustomAuthenticationStateProvider>();
builder.Services.AddScoped<ICustomAuthenticationStateProvider>(s => s.GetRequiredService<CustomAuthenticationStateProvider>());

builder.Services.AddCascadingAuthenticationState();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(pTodo.Shared._Imports).Assembly);

app.Run();

