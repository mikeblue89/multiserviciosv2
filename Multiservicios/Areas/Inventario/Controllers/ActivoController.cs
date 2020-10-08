using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Multiservicios.Data;

namespace Multiservicios.Areas.Inventario.Controllers
{
    [Area("Inventario")]
    public class ActivoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ActivoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var activo = await _db.Activo.Include(s => s.Marca).ToArrayAsync();
            var active = await _db.Activo.Include(s => s.Marca).ToArrayAsync();

            return View(activo);
        }
    }
}
