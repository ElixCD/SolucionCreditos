using Microsoft.AspNetCore.Mvc;
using SolucionCreditos.Business;
using SolucionCreditos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolucionCreditos.Controllers
{
    public class CuentasController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        public IActionResult Index()
        {
            Int64 idCliente = Int64.Parse(RouteData.Values["id"].ToString());
            ViewBag.idCliente = idCliente;
            CuentaBusiness cuentaBusiness = new CuentaBusiness();

            List<Cuenta> cuentas = cuentaBusiness.ListarCuentas(idCliente).Select(c => c).ToList();

            return View(cuentas);
        }

        
        public IActionResult Crear()
        {
            return  View();
        }

        [HttpPost]
        public IActionResult Crear(Cuenta cuenta)
        {
            Int64 idCliente = Int64.Parse(RouteData.Values["id"].ToString());
            CuentaBusiness cuentaBusiness = new CuentaBusiness();
            cuentaBusiness.GuardarCuenta(cuenta, idCliente);

            List<Cuenta> cuentas = cuentaBusiness.ListarCuentas(idCliente).Select(c => c).ToList();

            return View("Index", cuentas);
        }



    }
}
