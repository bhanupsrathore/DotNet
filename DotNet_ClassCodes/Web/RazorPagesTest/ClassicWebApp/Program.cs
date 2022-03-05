using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ClassicWebApp.Data.ShopDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb"));
});
builder.Services.AddAuthentication("Cookies")
    .AddCookie(options => options.LoginPath = "/Index");

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
