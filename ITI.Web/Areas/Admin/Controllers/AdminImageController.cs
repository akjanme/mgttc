using ITI.Models;
using ITI.Web.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace ITI.Web.Areas.Admin.Controllers
{
    public class AdminImageController : Controller
    { 
        protected MgttcEntities mgttcEntities;
        public AdminImageController()
        {
            mgttcEntities = new MgttcEntities();
        }
        public ActionResult Index()
        {
            IEnumerable<ImageModel> image = from x in mgttcEntities.ImageGalleries
                                            select new ImageModel
                                            {
                                                ID = x.ID,
                                                ImagDesc = x.ImagDesc,
                                                ImageUrl = x.ImageUrl
                                            };
            return View(image);
        }

        public ActionResult Create(int id = 0)
        {
            ImageGallery imageGallery = new ImageGallery();
            if (id > 0)
            {
                imageGallery = mgttcEntities.ImageGalleries.FirstOrDefault(x=>x.ID==id);
            }
            ImageModel imageModel = new ImageModel
            {
                ID = imageGallery.ID,
                ImagDesc = imageGallery.ImagDesc,
                ImageUrl = imageGallery.ImageUrl
            };
            return View(imageModel);
        }

        [HttpPost]
        public ActionResult Create(ImageModel imageModel)
        {
            try
            {
                if (imageModel.FileName.ContentLength > 0)
                {
                    if (!base.ModelState.IsValid)
                    {
                        return View(imageModel);
                    }
                    string _FileName = Path.GetFileName(imageModel.FileName.FileName);
                    string _path = Path.Combine(base.Server.MapPath("~/UploadedFiles"), _FileName);
                    imageModel.FileName.SaveAs(_path);
                    ImageGallery imageGallery = new ImageGallery
                    {
                        ID = imageModel.ID,
                        ImagDesc = imageModel.ImagDesc,
                        ImageUrl = "/UploadedFiles/" + _FileName
                    };
                    if (imageGallery.ID > 0)
                    {
                        ImageGallery result = mgttcEntities.ImageGalleries.Add(imageGallery);
                    }
                    else
                    {
                        mgttcEntities.ImageGalleries.Add(imageGallery);
                    }
                    mgttcEntities.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(imageModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            new ImageGallery();
            if (id > 0)
            {
                ImageGallery image = mgttcEntities.ImageGalleries.FirstOrDefault(x=>x.ID==id);
                if (image != null && !string.IsNullOrEmpty(image.ImageUrl) && System.IO.File.Exists(base.Server.MapPath(image.ImageUrl)))
                {
                    System.IO.File.Delete(base.Server.MapPath(image.ImageUrl));
                    mgttcEntities.ImageGalleries.Remove(image);
                }
            }
            return RedirectToAction("Index");
        }
    }
}