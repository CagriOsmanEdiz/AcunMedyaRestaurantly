using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;

namespace AcunMedyaRestaurantly.Controllers
{
        [Authorize]
    public class AdressController : Controller
    {

        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Adress
        public ActionResult Index()
        {
            var value = Db.Adresses.ToList();
            return View(value);
        
        }
        public ActionResult AdressesList()
        {
            var value = Db.Adresses.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AdressesCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdressesCreate(Adress model)
        {
            Db.Adresses.Add(model);
            Db.SaveChanges();
            return RedirectToAction("AdressesList");
        }
        [HttpGet]
        public ActionResult AdressesEdit(int id)
        {
            var value = Db.Adresses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult AdressesEdit(Adress model)
        {
            var values = Db.Adresses.Find(model.AdressId);
            values.Location = model.Location;
            values.OpenHours = model.OpenHours;
            values.Email = model.Email;
            values.Call = model.Call;
            Db.SaveChanges();
            return RedirectToAction("AdressesList");
        }
        public ActionResult AdresDelete(int id)
        {
            var values = Db.Adresses.Find(id);
            Db.Adresses.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("AdressesList");
        }

    }
}