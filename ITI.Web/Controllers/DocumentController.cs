using ITI.Models;
using ITI.Web.Data;
using System.Linq;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{

    public class DocumentController : Controller
    {
        protected MgttcEntities mgttcEntities;
        public DocumentController()
        {
            mgttcEntities = new MgttcEntities();
        }
        public ActionResult Index()
        {
            DocumentViewModel documentViewModel = new DocumentViewModel
            {
                Documents = mgttcEntities.Documents.ToList()
            }; 
            ViewBag.Message = TempData["Message"];
            return View(documentViewModel);
        }
    } 
}