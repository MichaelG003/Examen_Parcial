using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appRemesas.Models;
using appRemesas.Data;
using Microsoft.EntityFrameworkCore;

namespace appRemesas.Controllers
{
    
    public class TransaccionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransaccionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para listar todas las remesas
        public async Task<IActionResult> Lista()
        {
            // Aquí puedes filtrar por usuario si tienes una forma de identificar al usuario
            var remesas = await _context.Remesas.ToListAsync(); // Obtener todas las remesas

            return View(remesas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}