using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Famms_MVC.Controllers
{
    public class AboutController : Controller
    {
             public ActionResult Index()
        {
            return View();
        }
       
    }
}
