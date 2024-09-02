using Microsoft.AspNetCore.Mvc;
using ExamenMVC_AJAX.Models;

namespace ExamenMVC_AJAX.Controllers
{
    public class Productos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
