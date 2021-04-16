using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindWeb.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly NorthwindContext _context;

        public ProveedoresController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Suppliers);
               
        }
        public async Task<IActionResult> Detalles (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidor = await _context.Suppliers
                .FirstOrDefaultAsync(i => i.SupplierId == id);

            return View(suplidor);
        }
    }
}
