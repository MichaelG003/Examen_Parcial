using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appRemesas.Models;
using appRemesas.Data;

namespace appRemesas.Controllers
{
    
    public class RemesaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RemesaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar el formulario de registro
        public IActionResult Crear()
        {
            return View();
        }

        // Acción para manejar el registro de remesas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Remesa remesa)
        {
            if (ModelState.IsValid)
            {
                remesa.FechaRegistro = DateTime.UtcNow;
                _context.Remesas.Add(remesa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Lista","Transacciones"); // Redirige a la lista de remesas
            }
            return View(remesa); // Si hay errores, vuelve a mostrar el formulario
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}