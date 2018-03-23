using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using VehicleApp.Model;
using VehicleApp.Service.Interfaces;

namespace VehicleApp.Controllers
{
    public class HomeController : Controller
    {
        IVehicleService vehicleService;

        public HomeController() { }

        public HomeController(IVehicleService vehicleService) {
            this.vehicleService = vehicleService;
        }
        
        public ActionResult Index()
        {
            return View(vehicleService.GetAll());
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(VehicleModel obj)
        {
            if (ModelState.IsValid)
            {
                vehicleService.Add(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var obj = vehicleService.FindById(id);

            if (obj == null)
            {
                return HttpNotFound();
            }

            return View(obj);
        }

        // POST: Edit
        [HttpPost]
        public ActionResult Edit(VehicleModel obj)
        {
            if (ModelState.IsValid)
            {
                vehicleService.Edit(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        // POST: Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            vehicleService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
