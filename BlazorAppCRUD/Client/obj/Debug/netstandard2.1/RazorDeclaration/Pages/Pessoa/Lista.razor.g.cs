#pragma checksum "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\Pages\Pessoa\Lista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ed7b0e015bc3f2f6d38dfbd0ecd4e855cf72dd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppCRUD.Client.Pages.Pessoa
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using BlazorAppCRUD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using BlazorAppCRUD.Client.Pages.Pessoa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using BlazorAppCRUD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\_Imports.razor"
using BlazorAppCRUD.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pessoa")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pessoa/lista")]
    public partial class Lista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\bruno.welausen\source\repos\BlazorAppCRUD\BlazorAppCRUD\Client\Pages\Pessoa\Lista.razor"
       
    List<Pessoa> pessoas;

    protected override async Task OnInitializedAsync() {
        await LoadPessoas();
    }

    private async Task LoadPessoas() {
        pessoas = await http.GetFromJsonAsync<List<Pessoa>>("api/pessoa");

        //await Task.Delay(500);

        //pessoas = new List<Pessoa> {
        //    new Pessoa { Id=1, Nome="Testerino", Peso=100 },
        //    new Pessoa { Id=3, Nome="Testerina", Peso=75 },
        //};
    }

    private async Task ExcluirPessoa(int id) {
        await http.DeleteAsync($"api/pessoa/{id}");
        await LoadPessoas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
