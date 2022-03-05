using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICounter, GlobalCounter>();

var app = builder.Build();
//mapping path X/Y/z to XController::Y(z)
app.MapControllerRoute("default", "{controller=Greeter}/{action=Greet}/{id=Visitor}");
app.Run();
