using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace  DemoMVC.Controllersdot
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

   
    }
}