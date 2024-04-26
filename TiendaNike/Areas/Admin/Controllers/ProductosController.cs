using Microsoft.AspNetCore.Mvc;
using TiendaNike.AccesoDatos.Data.Repository.IRepository;
using TiendaNike.Models;

namespace TiendaNike.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public ProductosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Productos productos)
        {
            if (ModelState.IsValid)
            {
                //logica para guardar en bd
                _contenedorTrabajo.Productos.Add(productos);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(productos);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Productos almacen = new Productos();
            almacen = _contenedorTrabajo.Productos.Get(id);
            if (almacen == null)
            {
                return NotFound();

            }
            return View(almacen);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Productos productos)
        {

            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Productos.Update(productos);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }
        #region llamadas a la api
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Productos.GetAll() });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Productos.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando almacen" });
            }
            _contenedorTrabajo.Productos.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Se borro la almacen" });
        }
        #endregion
    }
}
