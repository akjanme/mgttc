using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;

namespace ITI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ImageRepository imgRepository;
        public HomeController()
        {
            imgRepository = new ImageRepository();
        }
        public ActionResult Default()
        { 
            return View();
        }
        public ActionResult ImageGelary()
        {
            var image = imgRepository.GetImageGalleries().Select(x => new ImageModel { ID = x.ID, ImagDesc = x.ImagDesc, ImageUrl = x.ImageUrl });
            return View(image);
        }
    }
}