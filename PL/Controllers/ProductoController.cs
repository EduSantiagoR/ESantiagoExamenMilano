using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class ProductoController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            ML.Result result = BL.Producto.GetAll();
            ML.Producto producto = new ML.Producto();
            producto.Productos = result.Objects;
            return View(producto);
        }
    }
}
