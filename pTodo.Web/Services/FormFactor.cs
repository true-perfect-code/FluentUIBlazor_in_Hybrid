using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using pTodo.Shared.Services;

namespace pTodo.Web.Services
{
    public class FormFactor : IFormFactor
    {
        private readonly IJSRuntime _jsRuntime;

        public FormFactor(IJSRuntime JSRuntime)
        {
            _jsRuntime = JSRuntime;
        }

        public string GetFormFactor()
        {
            return "Web";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }

        public async Task<double> SetDisplayColumns()
        {
            try
            {
                return 1000;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
