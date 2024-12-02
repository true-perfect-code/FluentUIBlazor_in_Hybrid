using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Authorization;

namespace pTodo.Shared.Pages
{
    public class TodoBase : LayoutComponentBase 
    {
        [Inject]
        AuthenticationStateProvider? authenticationStateProvider { get; set; }

        [Inject]
        IToastService toastService { get; set; }

        protected bool Hidden = true;
        protected bool _modal = true;

        bool? _canceled;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                if (firstRender)
                    StateHasChanged();
            }
            catch (Exception ex)
            {       
            }
        }


        #region FORM_EVENTS

        protected void OnClick_OpenToast()
        {
            toastService!.ShowSuccess("Successfully open FluentUI Blazor toast.", 3);
        }

        protected void onClick_Add()
        {
            try
            {
                Hidden = false;
            }
            catch (Exception ex)
            {
            }
        }

        protected void OnClick_()
        {

        }

        protected void OnClick_Close()
        {
            Hidden = true;
        }
        #endregion
    }
}
