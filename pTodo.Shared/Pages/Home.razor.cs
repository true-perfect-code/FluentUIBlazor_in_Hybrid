using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using pTodo.Shared.Services;
//using pTodo.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using pTodo.Shared.ViewModel.Basisklassen;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using pTodo.Shared.Pages;

namespace pTodo.Shared.Components.Pages
{
    public class HomeBase : LayoutComponentBase
    {
        [CascadingParameter]
        protected int langChanged { get; set; }

        [Inject]
        AuthenticationStateProvider? authenticationStateProvider { get; set; }

        [Inject]
        protected ICustomAuthenticationStateProvider? customAuthenticationStateProvider { get; set; }

        [Parameter]
        public string? error { get; set; }

        protected bool PageLoading = false;


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                StateHasChanged();
            }
        }

    }
}

