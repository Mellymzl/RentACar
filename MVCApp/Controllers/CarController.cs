﻿using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace MVCApp.Controllers
{
    public class CarController : Controller
    {
        ICarService _carService;

        public CarController(ICarService carService)
        {
            this._carService = carService;
        }

        public IActionResult Index()
        {

            return View(this._carService.GetAll());
        }
    }
}

