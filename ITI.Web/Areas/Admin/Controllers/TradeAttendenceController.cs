using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
   // [SessionFilter]
    //public class TradeAttendenceController : Controller
    //{
    //    //private ITIDataEntities db = new ITIDataEntities();

    //    // GET: Admin/TradeAttendence
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    //// GET: Admin/TradeAttendence/Details/5
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        TradeAttendence Model = db.TradeAttendences.Find(id);
    //        if (Model == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(Model);
    //    }

    //    // GET: Admin/TradeAttendence/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Admin/TradeAttendence/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "ID,Trade,NU_1,NU_2,NU_3,NT_onRoll_1,NT_onRoll_2,NT_onRoll_3,NT_Avail_1,NT_Avail_2,NT_Avail_3,Av_Att_1")] TradeAttendence Model)
    //    {
    //        if (string.IsNullOrEmpty(Model.Trade))
    //        {
    //            ModelState.AddModelError("Trade", "Trade Required");
    //        }
    //        if (ModelState.IsValid)
    //        {
    //            db.TradeAttendences.Add(Model);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(Model);
    //    }

    //    // GET: Admin/TradeAttendence/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        TradeAttendence Model = db.TradeAttendences.Find(id);
    //        if (Model == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(Model);
    //    }

    //    //// POST: Admin/TradeAttendence/Edit/5
    //    //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "ID,Trade,NU_1,NU_2,NU_3,NT_onRoll_1,NT_onRoll_2,NT_onRoll_3,NT_Avail_1,NT_Avail_2,NT_Avail_3,Av_Att_1")] TradeAttendence Model)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(Model).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(Model);
    //    }

    //    // GET: Admin/TradeAttendence/Delete/5
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        TradeAttendence Model = db.TradeAttendences.Find(id);
    //        if (Model == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(Model);
    //    }

    //    // POST: Admin/TradeAttendence/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        TradeAttendence Model = db.TradeAttendences.Find(id);
    //        db.TradeAttendences.Remove(Model);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
   // }
}
