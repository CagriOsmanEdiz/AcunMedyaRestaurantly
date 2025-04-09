using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    [Authorize]
    public class GalleryController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Gallery

        public ActionResult Index()
        {
            var value = Db.Galleries.ToList();
            return View(value);
        }
        public ActionResult GalleryList()
        {
            var value = Db.Galleries.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult GalleryCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GalleryCreate(Gallery model)
        {
            Db.Galleries.Add(model);
            Db.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        [HttpGet]
        public ActionResult GalleryEdit(int id)
        {
            var value = Db.Galleries.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult GalleryEdit(Gallery model)
        {
            var values = Db.Galleries.Find(model.GalleryId);
            values.ImageUrl = model.ImageUrl;
            Db.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        public ActionResult GalleryDelete(int id)
        {
            var values = Db.Galleries.Find(id);
            Db.Galleries.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("GalleryList");
        }
    }
}