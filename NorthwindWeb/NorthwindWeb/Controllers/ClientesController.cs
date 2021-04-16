using Microsoft.AspNetCore.Mvc;
using NorthwindWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindWeb.Controllers
{
    public class ClientesController : Controller
    {
        private readonly NorthwindContext _context;

        public ClientesController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Customers.ToList());
        }
    }
}
