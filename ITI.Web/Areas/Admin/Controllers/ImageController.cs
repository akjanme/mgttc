using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;
using System.IO;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class ImageController : Controller
    {
        //private readonly ImageRepository imageRepository;
        //public ImageController()
        //{
        //    imageRepository = new ImageRepository();
        //}

        //public ActionResult Index()
        //{
        //    var image = imageRepository.GetImageGalleries().Select(x => new ImageModel { ID = x.ID, ImagDesc = x.ImagDesc, ImageUrl = x.ImageUrl });
        //    return View(image);
        //}
        //public ActionResult Create(int id = 0)
        //{
        //    ImageGallery imageGallery = new ImageGallery();
        //    if (id > 0)
        //    {
        //        imageGallery = imageRepository.GetImageGalleryById(id);
        //    }
        //    ImageModel imageModel = new ImageModel
        //    {
        //        ID = imageGallery.ID,
        //        ImagDesc = imageGallery.ImagDesc,
        //        ImageUrl = imageGallery.ImageUrl
        //    };
        //    return View(imageModel);
        //}

        //[HttpPost]
        //public ActionResult Create(ImageModel imageModel)
        //{
        //    try
        //    {
        //        if (imageModel.FileName.ContentLength > 0)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                string _FileName = Path.GetFileName(imageModel.FileName.FileName);
        //                string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
        //                imageModel.FileName.SaveAs(_path);


        //                ImageGallery imageGallery = new ImageGallery
        //                {
        //                    ID = imageModel.ID,
        //                    ImagDesc = imageModel.ImagDesc,
        //                    ImageUrl = "/UploadedFiles/" + _FileName
        //                };
        //                if (imageGallery.ID > 0)
        //                {
        //                    imageRepository.UpdateImage(imageGallery);
        //                }
        //                else
        //                {
        //                    imageRepository.InsertImage(imageGallery);
        //                }

        //            }
        //            else
        //            {
        //                return View(imageModel);
        //            }
        //        }

        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception )
        //    {
        //        return View(imageModel);
        //    }
        //}
        //public ActionResult Delete(int id = 0)
        //{
        //    ImageGallery imageGallery = new ImageGallery();
        //    if (id > 0)
        //    {
        //        imageRepository.DeleteImage(id);
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}