using Microsoft.AspNetCore.Mvc;
using SolucionCreditos.Business;
using SolucionCreditos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Controllers
{
    public class TipoMovimientosController : Controller
    {
        public IActionResult Index()
        {
            TipoMovimientoBusiness tipoMovimientoBusiness = new TipoMovimientoBusiness();

            List<TipoMovimiento> clientes = tipoMovimientoBusiness.ListarTipoMovimiento().Select(p => p).ToList();

            return View(clientes);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoMovimiento tipoMovimiento)
        {
            TipoMovimientoBusiness tipoMovimientoBusiness = new TipoMovimientoBusiness();
            tipoMovimientoBusiness.GuardarTipoMovimiento(tipoMovimiento);

            List<TipoMovimiento> clientes = tipoMovimientoBusiness.ListarTipoMovimiento().Select(p => p).ToList();

            return View("Index", clientes);
        }
    }
}
