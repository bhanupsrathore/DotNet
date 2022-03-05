using BasicWebApp.Middlewares;
using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<ICounter, GlobalCounter>();
builder.Services.AddSingleton<ICounter, NamedCounter>();

var app = builder.Build();
app.UseMiddleware<Pausing>(TimeSpan.FromSeconds(5));
app.UseMiddleware<Greeting>();
app.Run();
