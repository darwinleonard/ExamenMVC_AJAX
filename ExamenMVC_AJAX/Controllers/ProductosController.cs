using Microsoft.AspNetCore.Mvc;
using ExamenMVC_AJAX.Models;

namespace ExamenMVC_AJAX.Controllers
{
    public class ProductosController : Controller
    {

        //

        private readonly Context _context;

        public ProductosController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View();
        }



        //


 


    }
}
