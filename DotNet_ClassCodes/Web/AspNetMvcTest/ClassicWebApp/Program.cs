var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<Tourism.ISiteStore, Tourism.Persistence.XmlSiteStore>();
builder.Services.AddTransient<Tourism.ISiteStore, Tourism.Persistence.DbSiteStore>();
var app = builder.Build();
app.MapDefaultControllerRoute(); // {controller=Home}/{action=Index}/{id=null}
app.Run();
