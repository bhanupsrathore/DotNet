using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers;
using Services;

public class GreeterController : Controller
{
    //GET /Greeter/Leave/{name}
    public IActionResult Leave(string id)
    {
        return Content($"Goodbye {id}");
    }

    public IActionResult Greet(string id, [FromServices] ICounter ctr)
    {
        ViewBag.VisitorName = id;
        int count = ctr.CountNext(id);
        if((count % 2) == 1)
            return View("~/Views/Welcome.cshtml");
        return View("~/Views/Hello.cshtml");
    }
}
