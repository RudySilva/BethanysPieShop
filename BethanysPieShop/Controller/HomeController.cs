﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            //ViewBag.Title = "Pie overview";

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}