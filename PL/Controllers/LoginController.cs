using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            ML.Result resultTiendas = BL.Tienda.GetAll();
            ML.Result resultEmpleados = BL.Usuario.GetByIdTienda(0);
            ML.Usuario usuario = new ML.Usuario();
            usuario.TiendaAsignada.Tiendas = resultTiendas.Objects;
            usuario.Empleados = resultEmpleados.Objects;
            return View(usuario);
        }
        [HttpPost]
        public IActionResult CambiarVista()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("Login/UsuarioGetByIdTienda")]
        public IActionResult UsuarioGetByIdTienda(int idTienda)
        {
            ML.Result resultUsuarios = BL.Usuario.GetByIdTienda(idTienda);
            return Json(resultUsuarios.Objects);
        }
    }
}
