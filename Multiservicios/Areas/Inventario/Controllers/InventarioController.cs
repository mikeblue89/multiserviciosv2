using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Multiservicios.Areas.Inventario.Controllers
{
    public class InventarioController : Controller
    {
        [Area("Inventario")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
