using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using pTodo.Shared.Services;

namespace pTodo
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider, ICustomAuthenticationStateProvider
    {
        private readonly IServiceProvider serviceProvider;

        public CustomAuthenticationStateProvider()
        {
        }

        public CustomAuthenticationStateProvider(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public async Task Login(string token)
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task Logout()
        {
            await Task.Run(() =>
            {
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            });
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
               
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}
