using ITI.Models;
using ITI.Web.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace ITI.Web.Areas.Admin.Controllers
{
    public class AdminDocumentController : Controller
    {
        protected MgttcEntities mgttcEntities;
        public AdminDocumentController()
        {
            mgttcEntities = new MgttcEntities();
        }
        // GET: Admin/Document
        public ActionResult Index()
        {
            var fileuploadViewModel = LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        [HttpPost]
        public ActionResult Index(DocumentModel documentModel)
        {
            string basePath = Path.Combine(base.Server.MapPath("~/Documents"));
            bool basePathExists = System.IO.Directory.Exists(basePath);
            if (!basePathExists) Directory.CreateDirectory(basePath);
            var filePath = Path.Combine(basePath, documentModel.Document.FileName);
            var extension = Path.GetExtension(documentModel.Document.FileName);
            if (documentModel.Document.ContentLength > 0)
            {
                if (!base.ModelState.IsValid)
                {
                    return View(documentModel);
                }
                string _FileName = Path.GetFileName(documentModel.Document.FileName);
                string _path = Path.Combine(base.Server.MapPath("~/Documents"), _FileName);
                documentModel.Document.SaveAs(_path);
                Document document = new Document
                {
                    ID = documentModel.ID,
                    DocName = documentModel.DocName,
                    DocUrl = _FileName,
                    DocDescription=documentModel.DocDescription
                };
                if (document.ID > 0)
                {
                    Document result = mgttcEntities.Documents.Add(document);
                }
                else
                {
                    mgttcEntities.Documents.Add(document);
                }
                mgttcEntities.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to File System.";
            return RedirectToAction("Index");
        }
        public ActionResult DownloadFile(int id)
        {
            var file = mgttcEntities.Documents.Where(x => x.ID == id).FirstOrDefault();
            if (file == null) return null;
            string basePath = Path.Combine(base.Server.MapPath("~/Documents"));
            var filePath = Path.Combine(basePath, file.DocUrl);
            var extension = Path.GetExtension(file.DocUrl);
            return File(filePath, GetMimeType(extension));
        }
        private DocumentViewModel LoadAllFiles()
        {
            DocumentViewModel documentViewModel = new DocumentViewModel
            {
                Documents = mgttcEntities.Documents.ToList()
            };
            return documentViewModel;
        }
        public ActionResult DeleteFileFromFileSystem(int id)
        {
            string basePath = Path.Combine(base.Server.MapPath("~/Documents")); 
            var file = mgttcEntities.Documents.Where(x => x.ID == id).FirstOrDefault();
            if (file == null) return null;
            var filePath = Path.Combine(basePath, file.DocName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            mgttcEntities.Documents.Remove(file);
            mgttcEntities.SaveChanges();
            TempData["Message"] = $"Removed {file.DocName } successfully from File System.";
            return RedirectToAction("Index", "AdminDocument");
        }
        public static string GetMimeType(string extension)
        {
            if (extension == null)
                throw new ArgumentNullException("extension");
            if (extension.StartsWith("."))
                extension = extension.Substring(1);
            switch (extension.ToLower())
            {
                case "bmp": return "image/bmp";
                case "doc": return "application/msword";
                case "docm": return "application/vnd.ms-word.document.macroenabled.12";
                case "docx": return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case "jpe": return "image/jpeg";
                case "jpeg": return "image/jpeg";
                case "jpg": return "image/jpeg";
                case "png": return "image/png";
                case "pdf": return "application/pdf";
                case "ppt": return "application/vnd.ms-powerpoint";
                case "pptx": return "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                case "txt": return "text/plain";
                case "xls": return "application/vnd.ms-excel";
                case "xlsb": return "application/vnd.ms-excel.sheet.binary.macroenabled.12";
                case "xlsm": return "application/vnd.ms-excel.sheet.macroenabled.12";
                case "xlsx": return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"; 
                default: return "application/octet-stream";
            }
        }
    }
}