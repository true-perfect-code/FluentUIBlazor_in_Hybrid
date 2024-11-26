using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using pTodo.Shared.Services;
using System.Security.Claims;

namespace web
{
    public class CookieAuthStateProvider : RevalidatingServerAuthenticationStateProvider
    {
        public CookieAuthStateProvider(ILoggerFactory loggerFactory) : base(loggerFactory)
        {
        }

        protected override TimeSpan RevalidationInterval => TimeSpan.FromDays(30);

        protected override Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            var result = false;
            return Task.FromResult(result);
        }
    }

    public class CustomAuthenticationStateProvider : ICustomAuthenticationStateProvider
    {
        public Task Login(string token)
        {
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            return Task.CompletedTask;
        }
    }
}

