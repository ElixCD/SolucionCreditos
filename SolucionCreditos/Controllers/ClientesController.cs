using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SolucionCreditos.Business;
using SolucionCreditos.Entities;
using SolucionCreditos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionCreditos.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            ClientesBusiness clientesBusiness = new ClientesBusiness();

            List<ClienteViewModel> clientes =  clientesBusiness.ListarClientes().Select(p=> new ClienteViewModel()
            {
                IdCliente = p.IdCliente,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Cuentas = p.Cuentas,
                NombreCompleto = p.Nombre + ' ' + p.Apellido
            }).ToList();

            return View(clientes);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Cliente cliente)
        {
            ClientesBusiness clienteBusiness = new ClientesBusiness();
            clienteBusiness.GuardarCliente(cliente);

            List<ClienteViewModel> clientes = clienteBusiness.ListarClientes().Select(p => new ClienteViewModel()
            {
                IdCliente = p.IdCliente,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Cuentas = p.Cuentas,
                NombreCompleto = p.Nombre + ' ' + p.Apellido
            }).ToList();

            return View("Index", clientes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
