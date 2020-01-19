using ITI.Data;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Models;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class PlacementController : Controller
    {
        private readonly PlacementTableRepository placementTableRepository;
        public PlacementController()
        {
            placementTableRepository = new PlacementTableRepository();
        }
        // GET: Admin/Placement
        public ActionResult Index()
        {
            var placements = placementTableRepository.GetPlacementTables().Select(x => new PlacementTableModel {ID=x.ID,Name=x.Name,Trade=x.Trade,SalaryOnJoin=x.SalaryOnJoin});
            return View(placements);
        }
        public ActionResult Create(int id =0)
        {
            ViewBag.Trade = StaticData.GetTrade();
            PlacementTable placementTable = new PlacementTable();
            if (id > 0)
            {
                placementTable = placementTableRepository.GetPlacementbyID(id);
            }
            PlacementTableModel placementTableModel = new PlacementTableModel
            {
                ID = placementTable.ID,
                Name=placementTable.Name,
                Org_Name=placementTable.Org_Name,
                SalaryOnJoin=placementTable.SalaryOnJoin,
                Trade=placementTable.Trade,
                PassingYear=placementTable.PassingYear,
                Roll_No=placementTable.Roll_No
            };
            return View(placementTableModel);
        }

        [HttpPost]
        public ActionResult Create(PlacementTableModel placementTableModel)
        {
            try
            {
                PlacementTable placementTable = new PlacementTable
                {
                    ID = placementTableModel.ID,
                    Name = placementTableModel.Name,
                    Org_Name = placementTableModel.Org_Name,
                    SalaryOnJoin = placementTableModel.SalaryOnJoin,
                    Trade = placementTableModel.Trade,
                    PassingYear = placementTableModel.PassingYear,
                    Roll_No = placementTableModel.Roll_No
                };
                ViewBag.Trade = StaticData.GetTrade();
                if (ModelState.IsValid)
                {
                    if (placementTable.ID > 0)
                    {
                        placementTableRepository.UpdatePlacement(placementTable);
                    }
                    else
                    {
                        placementTableRepository.InsertPlacement(placementTable);
                    }
                }
                else
                {
                    return View(placementTableModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(placementTableModel);
            }
        }
        public ActionResult Delete(int id = 0)
        {
            PlacementTable placementTable = new PlacementTable();
            if (id > 0)
            {
                placementTableRepository.DeletePlacement(id);
            }
            return RedirectToAction("Index");
        }
    }
}