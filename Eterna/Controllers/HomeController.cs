using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context; 

        }
        public IActionResult Index() 
        {

            //List<Slider> sliders=_context.Sliders.ToList();

            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),
            };

            #region First creation
            //List<Slider> sliders = new List<Slider>
            //{
            //    new Slider
            //    {
            //     Id = 1,
            //     Image = "slide-2.jpg",
            //     Title ="Ukraine tension: President ",
            //     KeyWord = "Zelensky",
            //     Desc ="Ukraine's President Volodymyr Zelensky has hit back at comments made by his US counterpart Joe Biden about",
            //     RedirectUrl = "https://www.google.com",
            //     Order = 2,
            //    },
            //    new Slider
            //    {
            //     Id = 2,
            //     Image = "slide-1.jpg",
            //     Title ="Welcome to",
            //     KeyWord = "Baku comments",
            //     Desc ="Ukraine's President Volodymyr Zelensky has hit back at comments made by his US counterpart Joe Biden about",
            //     RedirectUrl = "https://www.shazam.com",
            //     Order=1,
            //    },
            //    new Slider
            //    {
            //     Id = 3,
            //     Image = "slide-3.jpg",
            //     Title ="Ukraine Okay ",
            //     KeyWord = "Zelensky ",
            //     Desc ="Ukraine's President Volodymyr Zelensky has hit back at comments made by his US counterpart Joe Biden about",
            //     RedirectUrl = "https://www.youtube.com",
            //     Order=3
            //    }
            //};

            //List<Feature> features = new List<Feature>
            //{
            //  new Feature
            //  {
            //      Id = 1,
            //      Icon ="<i class='bi bi-bar-chart'></i>",
            //      Title = "Lorem ipsum",
            //      Desc = "111Yerussalem"
            //  },
            //   new Feature
            //  {
            //      Id = 2,
            //      Icon ="<i class='bi bi-binoculars'></i>",
            //      Title = "Barcelona ipsum",
            //      Desc = "222Yerussalem"
            //  },
            //    new Feature
            //  {
            //      Id = 3,
            //      Icon ="<i class='bi bi-card-checklist'></i>",
            //      Title = "Tragedy ipsum",
            //      Desc = "333Yerussalem"
            //  }
            //};

            //HomeVM model = new HomeVM
            //{
            //    Sliders = sliders.OrderBy(s => s.Order).ToList(),
            //    Features = features,
            //};
            #endregion

            return View(model);
        }
    }
}
