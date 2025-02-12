using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using ApoloHome.Componentes;

namespace ApoloHome.Pages
{
    public partial class Index : ComponentBase // Agregamos : ComponentBase
    {
        [Parameter]
        public string Locale { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; } // Asegúrate de inyectar JSRuntime si lo usas

        private RegistroModal RegistroRef { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("loadAnimaciones");
            }
        }

        protected override async Task OnInitializedAsync()
        {
            string currentIdioma = CultureInfo.CurrentCulture.ToString();
            Locale ??= currentIdioma;
        }
    }
}
