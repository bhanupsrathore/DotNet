namespace BasicWebApp.Middlewares;

using Services;

public class Greeting
{
    private readonly ICounter _counter;

    public Greeting(RequestDelegate next, ICounter counter)
    {
        _counter = counter;
    }

    public async Task Invoke(HttpContext context)
    {
        string greet = context.Request.Path.Value.Substring(1);
        if(greet.Length == 0)
            greet = "Greetings";
        int count = _counter.CountNext(greet);
        await context.Response.WriteAsync(@$"
            <html>
                <head>  
                    <title>BasicWebApp</title>
                </head>
                <body>
                    <h1>{greet} Visitor</h1>
                    <b>Current Time: </b> {DateTime.Now}
                    <p><b>Number of Greetings: </b>{count}</p>
                </body>
            </html>
        ");
    }
}