using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;
using ITI.Web.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Areas.Admin.Controllers
{
    [SessionFilter]
    public class TraineeResultController : Controller
    {
        private readonly TraineeRepository traineeRepository;
        public TraineeResultController()
        {
            traineeRepository = new TraineeRepository();
        }
        public ActionResult TraineeView()
        {
            var students = traineeRepository.GetTarineeLists().Select(x => new TraineeModel { ID = x.ID, AverageInspection=x.AverageInspection, InspectionFirst=x.InspectionFirst, InspectionSecond=x.InspectionSecond, InspectionThird=x.InspectionThird, Trade=x.Trade, TraineesFirst=x.TraineesFirst, TraineesSecond=x.TraineesSecond, TraineesThird=x.TraineesThird, UnitFirst=x.UnitFirst, UnitSecond=x.UnitSecond, UnitThird=x.UnitThird });
            return View(students);
        }
        public ActionResult TraineeCreate(int id = 0 )
        {
            TarineeList tarineeList = new TarineeList(); 
            if (id > 0)
            {
                tarineeList = traineeRepository.GetTarineeListById(id);
            }
            TraineeModel traineeModel =new TraineeModel 
            {
                ID = tarineeList.ID,
                AverageInspection= tarineeList.AverageInspection,
                InspectionFirst= tarineeList.InspectionFirst,
                InspectionSecond= tarineeList.InspectionSecond,
                InspectionThird= tarineeList.InspectionThird,
                TraineesThird= tarineeList.TraineesThird,
                TraineesSecond= tarineeList.TraineesSecond,
                Trade= tarineeList.Trade,
                TraineesFirst= tarineeList.TraineesFirst,
                UnitFirst= tarineeList.UnitFirst,
                UnitSecond= tarineeList.UnitSecond,
                UnitThird= tarineeList.UnitThird
            };
            return View(traineeModel);
        }
        [HttpPost]
        public ActionResult TraineeCreate(TraineeModel traineeModel)
        {
            try
            {
                TarineeList tarineeList =new TarineeList 
                {
                    ID = traineeModel.ID,
                    AverageInspection = traineeModel.AverageInspection,
                    InspectionFirst = traineeModel.InspectionFirst,
                    InspectionSecond = traineeModel.InspectionSecond,
                    InspectionThird = traineeModel.InspectionThird,
                    TraineesThird = traineeModel.TraineesThird,
                    TraineesSecond = traineeModel.TraineesSecond,
                    Trade = traineeModel.Trade,
                    TraineesFirst = traineeModel.TraineesFirst,
                    UnitFirst = traineeModel.UnitFirst,
                    UnitSecond = traineeModel.UnitSecond,
                    UnitThird = traineeModel.UnitThird
                };
                if (ModelState.IsValid)
                {
                    if (tarineeList.ID > 0)
                    {
                        traineeRepository.UpdateTarineeList(tarineeList);
                    }
                    else
                    {
                        traineeRepository.InsertTarineeList(tarineeList);
                    }
                }
                else
                { 
                    return View(tarineeList);
                }


                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(traineeModel);
            }
        }
        public ActionResult TDelete(int id = 0)
        {
            TraineeModel traineeModel = new TraineeModel();
            if (id > 0)
            {
                traineeRepository.DeleteTarineeLists(id); 
            }
            return RedirectToAction("Index");
        } 
    }
}