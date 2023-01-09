using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly FiorelloContext _fiorelloContext;

        public HomeController(FiorelloContext fiorelloContext)
        {
            _fiorelloContext = fiorelloContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel= new HomeViewModel
            {
                sliders = _fiorelloContext.sliders.ToList()
            };
            return View(homeViewModel);
        }

    }
}