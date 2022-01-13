using Microsoft.AspNetCore.Mvc;
using SolucionCreditos.Business;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionCreditos.Controllers
{
    public class DepositosController : Controller
    {
        public IActionResult Index()
        {
            MovimientoBusiness tipoMovimientoBusiness = new MovimientoBusiness();
            List<Movimiento> clientes = tipoMovimientoBusiness.ListarMovimiento().Select(p => p).ToList();
            return View();
        }
    }
}
