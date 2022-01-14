using Microsoft.AspNetCore.Mvc;
using SolucionCreditos.Business;
using SolucionCreditos.Entities;
using SolucionCreditos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Controllers
{
    public class MovimientosController : Controller
    {
        public IActionResult Index()
        {
            Int64 idCuenta = Int64.Parse(RouteData.Values["id"].ToString());
            ViewBag.idCuenta = idCuenta;

            CuentaBusiness cuentaBusiness = new CuentaBusiness(); 
            Int64 idCliente = cuentaBusiness.ObtenerCuentasPorId(idCuenta).IdCliente;
            ViewBag.idCliente = idCliente;

            MovimientoBusiness movimientoBusiness = new MovimientoBusiness();
            List<Movimiento> movimientos = movimientoBusiness.ListarMovimientosPorCuenta(idCuenta).Select(p => p).ToList();
            
            return View(movimientos);
        }

        public IActionResult NuevoMovimiento()
        {
            Int64 idCuenta = Int64.Parse(RouteData.Values["id"].ToString());
            ViewBag.idCuenta = idCuenta;
            CuentaBusiness cuentaBusiness = new CuentaBusiness();
            Int64 idCliente = cuentaBusiness.ObtenerCuentasPorId(idCuenta).IdCliente;
            ViewBag.idCliente = idCliente;

            MovimientoViewModel movimientoViewModel = new MovimientoViewModel();
            TipoMovimientoBusiness tipoMovimientoBusiness = new TipoMovimientoBusiness();
            movimientoViewModel.TipoMovimiento = tipoMovimientoBusiness.ListarTipoMovimiento().ToList();

            return View(movimientoViewModel);
        }

        [HttpPost]
        public IActionResult NuevoMovimiento(MovimientoViewModel movimientoViewModel)
        {
            Int64 idCuenta = Int64.Parse(RouteData.Values["id"].ToString());
            ViewBag.idCuenta = idCuenta;
            CuentaBusiness cuentaBusiness = new CuentaBusiness();
            Int64 idCliente = cuentaBusiness.ObtenerCuentasPorId(idCuenta).IdCliente;
            ViewBag.idCliente = idCliente;

            MovimientoBusiness movimientoBusiness = new MovimientoBusiness();
            ViewBag.Exito = movimientoBusiness.CrearMovimiento(movimientoViewModel.Movimiento);
            
            List<Movimiento> movimientos = movimientoBusiness.ListarMovimientosPorCuenta(idCuenta).Select(p => p).ToList();

            return View("Index", movimientos);
        }            
    }
}
