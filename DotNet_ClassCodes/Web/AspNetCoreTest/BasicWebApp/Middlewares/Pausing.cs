namespace BasicWebApp.Middlewares;

public class Pausing
{
    private readonly RequestDelegate _next;
    private readonly TimeSpan _delay;
    private DateTime _recent;

    public Pausing(RequestDelegate next, TimeSpan delay)
    {
        _next = next;
        _delay = delay;
    }

    public async Task Invoke(HttpContext context)
    {
        var current = DateTime.Now;
        if(current - _recent > _delay)
        {
            _recent = current;
            await _next.Invoke(context);
        }
        else
        {
            await context.Response.WriteAsync("Server busy, please try after some time...");
        }
    }
}