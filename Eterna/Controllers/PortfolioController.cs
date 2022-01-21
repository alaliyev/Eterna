using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class PortfolioController:Controller
    {
        private readonly AppDbContext _context; 
        public PortfolioController(AppDbContext context)
        {
            _context = context; 

        }
        public IActionResult Index() 
        {
            List<Portfolio> model = _context.Portfolios.ToList();

            return View(model);
        }

        public IActionResult Detail(int id)
            //.Include(p =>p.PortfolioImages)
        {
            Portfolio portfolio = _context.Portfolios.Include(p => p.Categories).Include(p => p.PortfolioImages).FirstOrDefault(p => p.Id == id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }
    }
}
