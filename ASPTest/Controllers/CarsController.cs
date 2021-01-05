using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPTest.Data.Interfaces;
using ASPTest.ViewModels;

namespace ASPTest.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarCategory allCategories;

        public CarsController(IAllCars iAllCars, ICarCategory iCarCategory)
        { 
            allCars = iAllCars;
            allCategories = iCarCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Cars Page";
            CarsListViewModel cars = new CarsListViewModel();
            cars.allCars = allCars.Cars;
            cars.currCategory = "Avtomobili";
            return View(cars);
        }

        public ViewResult More_Tesla()
        {   
            return View();
        }
    }
}
