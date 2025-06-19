using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AyuEmlak.Data;
using AyuEmlak.Models;

namespace AyuEmlak.Controllers
{
    public class EmlakController : Controller
    {
        private readonly EmlakDbContext _context;

        public EmlakController(EmlakDbContext context)
        {
            _context = context;
        }

        // Anasayfa - Tüm ilanlar
        public async Task<IActionResult> Index()
        {
            var emlaklar = await _context.Emlaklar.Include(e => e.Kategori).ToListAsync();
            return View(emlaklar);
        }
    }
}
