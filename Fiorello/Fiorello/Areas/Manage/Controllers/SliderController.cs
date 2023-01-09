﻿using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private readonly FiorelloContext _fiorelloContext;

        public SliderController(FiorelloContext fiorelloContext)
        {
            _fiorelloContext = fiorelloContext;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                sliders= _fiorelloContext.sliders.ToList()
            };


            return View(homeViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            
            _fiorelloContext.sliders.Add(slider);
            _fiorelloContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
