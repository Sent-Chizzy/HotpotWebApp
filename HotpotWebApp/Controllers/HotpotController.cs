using Microsoft.AspNetCore.Mvc;
using HotpotWebApp.Data;
using HotpotWebApp.Models;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

namespace HotpotWebApp.Controllers
{
    public class HotpotController : Controller
    {
        private readonly HotpotContext _context;
        public HotpotController(HotpotContext context)
        {
            _context= context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishes.ToListAsync());
        }
    }
}
