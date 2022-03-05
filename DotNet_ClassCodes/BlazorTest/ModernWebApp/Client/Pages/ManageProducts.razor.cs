using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace ModernWebApp.Client.Pages;

using System.Threading.Tasks;
using ModernWebApp.Shared;

partial class ManageProducts
{
    [Inject]
    public HttpClient Backend { get; set; } = null!;

    [Inject]
    public IJSRuntime Scripting { get; set; } = null!;

    public List<Product>? Items { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Items = await Backend.GetFromJsonAsync<List<Product>>("Products");
    }

    protected async Task UpdateProduct(Product item)
    {
        var response = await Backend.PutAsJsonAsync("Products", item);
        if(!response.IsSuccessStatusCode)
            await Scripting.InvokeVoidAsync("alert", $"Product {item.Id} update failed!");
    }
}
