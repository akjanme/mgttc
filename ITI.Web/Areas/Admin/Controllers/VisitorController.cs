using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Repository.Repository;
using ITI.Data;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class VisitorController : Controller
    {
        private readonly VisitorRepository visitorRepository;
        public VisitorController()
        {
            visitorRepository = new VisitorRepository();
        }
       
        public ActionResult Index()
        {
            var visitor = visitorRepository.GetVisitors().Select(x => new VisitorModel { ID = x.ID, vName = x.vName, Comment = x.Comment});
            return View(visitor);
        }

        public ActionResult Create(int id = 0)
        {
            Visitor visitor = new Visitor();
            if(id > 0)
            {
                visitor = visitorRepository.GetVisitorById(id);
            }
            VisitorModel visitorModel = new VisitorModel
            {
                ID=visitor.ID,
                Comment=visitor.Comment,
                vName=visitor.vName
            };
            return View(visitorModel);
        }

        [HttpPost]
        public ActionResult Create(VisitorModel visitorModel)
        {
            try
            {
                Visitor visitor = new Visitor
                {
                    ID = visitorModel.ID,
                    Comment = visitorModel.Comment,
                    vName = visitorModel.vName
                };
                if (ModelState.IsValid)
                {
                    if (visitor.ID > 0)
                    {
                        visitorRepository.UpdateVisitor(visitor);
                    }
                    else
                    {
                        visitorRepository.InsertVisitor(visitor);
                    }
                }
                else
                {
                    return View(visitorModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(visitorModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            Visitor visitor = new Visitor();
            if (id > 0)
            {
                visitorRepository.DelecteVisitor(id);
            }
            return RedirectToAction("Index");
        }

    }
}