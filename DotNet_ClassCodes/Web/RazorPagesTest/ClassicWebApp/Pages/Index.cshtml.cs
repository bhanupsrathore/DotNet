using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace ClassicWebApp.Pages;

using Data;

public class IndexModel : PageModel
{
    private readonly ShopDbContext _db;

    public IndexModel(ShopDbContext db) => _db = db;

    [BindProperty]
    public Customer Credentials { get; set; }

    public void OnGet()
    {
        Credentials = new Customer {Id = "CU201"};
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var customer = await _db.Customers.FindAsync(Credentials.Id);
        if(customer?.Password == Credentials.Password)
        {
            var identity = new ClaimsIdentity("Cookies");
            identity.AddClaim(new Claim(ClaimTypes.Name, Credentials.Id));
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return RedirectToPage("Detail");
        }
        ModelState.AddModelError("Credentials", "Authentication Failed!");
        return Page();
    }
}