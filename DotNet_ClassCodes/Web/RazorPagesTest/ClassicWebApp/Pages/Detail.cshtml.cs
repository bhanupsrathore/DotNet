using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace ClassicWebApp.Pages;

using Data;

[Authorize]
[ResponseCache(NoStore = true)]
public class DetailModel : PageModel
{
    private readonly ShopDbContext _db;

    public DetailModel(ShopDbContext db) => _db = db;

    public string CustomerName { get; set; }

    public List<Order> CustomerInvoice { get; set; }

    public void OnGet()
    {
        CustomerName = User.Identity.Name;
        CustomerInvoice = _db.Orders
                    .Where(c => c.CustomerId == CustomerName)
                    .ToList();
    }

    public async Task<IActionResult> OnGetLogout()
    {
        await HttpContext.SignOutAsync();
        return RedirectToPage("Index");
    }
}
