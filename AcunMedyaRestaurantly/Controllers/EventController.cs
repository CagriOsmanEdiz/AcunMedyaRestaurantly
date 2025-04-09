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
    public class EventController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Event
        public ActionResult Index()
        {
            var value = Db.Events.ToList();
            return View(value);
        }
        public ActionResult EventList()
        {
            var value = Db.Events.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult EventCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EventCreate(Event model)
        {
            Db.Events.Add(model);
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
        [HttpGet]
        public ActionResult EventEdit(int id)
        {
            var value = Db.Events.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EventEdit(Event model)
        {
            var values = Db.Events.Find(model.EventId);
            values.Title = model.Title;
            values.Price = model.Price;
            values.Description = model.Description;
            values.ImageUrl = model.ImageUrl;
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
        public ActionResult EventDelete(int id)
        {
            var values = Db.Events.Find(id);
            Db.Events.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
    }
}