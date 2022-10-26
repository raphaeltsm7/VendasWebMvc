﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VendasWebMvc.Models.ViewModels;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Web Application MVC";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About the Web App";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new VendasWebMvc.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}