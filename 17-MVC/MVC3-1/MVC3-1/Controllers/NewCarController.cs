using MVC3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.Controllers
{
    public class NewCarController : Controller
    {
        // GET: NewCar

        public ActionResult GetAllCars()
        {
            List<Car> carLst = CarList.cars;
            //ViewBag.Cars = carLst;
            return View(carLst);
        }

        public ActionResult SelectCarById(int num)
        {
            Car selectedCar = CarList.cars.FirstOrDefault(c => c.Num == num); ;
            return View(selectedCar);
        }
        //public ActionResult CreateNewCar()
        //{
        //    List<Car> carLst = CarList.cars;
        //    ViewBag.Cars = carLst;
        //    return View();
        //}

        public ActionResult UpdateCar(int num)
        {
            //ViewBag.selectedCar = CarList.cars.FirstOrDefault(c => c.Num == num);
            Car selectedCar = CarList.cars.FirstOrDefault(c => c.Num == num);
            return View(selectedCar);
        }
        [HttpPost]
        public ActionResult UpdateCar(int num, string color, string model, string manufacture)

        {
            Car editedCar = CarList.cars.FirstOrDefault(c => c.Num == num);
            editedCar.Color = color;
            editedCar.Model = model;
            editedCar.Manfacture = manufacture;
            return RedirectToAction("GetAllCars");
        }
        public ActionResult AddCar()

        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCar(int num, string color, string model, string manufacture)

        {
            Car newCar = new Car();
            newCar.Color = color;
            newCar.Model = model;
            newCar.Manfacture = manufacture;
            CarList.cars.Add(newCar);
            return RedirectToAction("GetAllCars");
        }
        public ActionResult DeleteCar(int num)
        {
            var deletedCar = CarList.cars.FirstOrDefault(c => c.Num == num); ;
            CarList.cars.Remove(deletedCar);
            return RedirectToAction("GetAllCars");
        }
    }
}