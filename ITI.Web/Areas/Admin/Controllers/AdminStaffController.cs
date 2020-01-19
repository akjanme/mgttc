using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;
using ITI.Web.Filter;

namespace ITI.Web.Areas.Admin.Controllers
{
    
    public class AdminStaffController : Controller
    {
        private readonly StaffRepository staffRepository;
        public AdminStaffController()
        {
            staffRepository = new StaffRepository();
        }
        // GET: Admin/AdminStaff
        public ActionResult Technical()
        {
            var tech = staffRepository.GetStaff().Select(x => new StaffModel { ID = x.ID, ACDetails = x.ACDetails, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, Name = x.Name, PhotoGraph = x.PhotoGraph, Qualification = x.Qualification, Salary = x.Salary, SchoolMatric = x.SchoolMatric, Staff = x.Staff });
            return View(tech);
        }
        public ActionResult Academic()
        {
            var academic = staffRepository.GetStaff().Select(x => new StaffModel { ID = x.ID, ACDetails = x.ACDetails, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, Name = x.Name, PhotoGraph = x.PhotoGraph, Qualification = x.Qualification, Salary = x.Salary, SchoolMatric = x.SchoolMatric, Staff = x.Staff });
            return View(academic);
        }
        public ActionResult AddStaff(int id = 0)
        {
            StaffTable staffTable = new StaffTable();
            if (id > 0)
            {
                staffTable = staffRepository.GetStaffById(id);
            }
            ViewBag.Session = StaticData.GetStaffAT();

            StaffModel staffModel = new StaffModel()
            {
                ID = staffTable.ID,
                ACDetails = staffTable.ACDetails,
                DateOfBirth = staffTable.DateOfBirth,
                DateOfJoin = staffTable.DateOfJoin,
                Designation = staffTable.Designation,
                Salary = staffTable.Salary,
                Experience = staffTable.Experience,
                SchoolMatric = staffTable.SchoolMatric,
                Name = staffTable.Name,
                PhotoGraph = staffTable.PhotoGraph,
                Staff = staffTable.Staff,
                Qualification = staffTable.Qualification
            };
            return View(staffModel);
        }
        [HttpPost]
        public ActionResult AddStaff(StaffModel staffModel)
        {
            try
            { 
                if (staffModel.FileName.ContentLength > 0)
                {
                    if (ModelState.IsValid)
                    {
                        string _PhotoName = Path.GetFileName(staffModel.FileName.FileName).Replace(" ","");
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _PhotoName);
                        staffModel.FileName.SaveAs(_path);

                        StaffTable staffTable = new StaffTable()
                        {
                            ID = staffModel.ID,
                            ACDetails = staffModel.ACDetails,
                            DateOfBirth = staffModel.DateOfBirth,
                            DateOfJoin = staffModel.DateOfJoin,
                            Designation = staffModel.Designation,
                            Salary = staffModel.Salary,
                            Experience = staffModel.Experience,
                            SchoolMatric = staffModel.SchoolMatric,
                            Name = staffModel.Name,
                            Staff = staffModel.Staff,
                            Qualification = staffModel.Qualification,
                            PhotoGraph = "/UploadedFiles/" + _PhotoName
                        };

                        if (staffTable.ID > 0)
                        {
                            staffRepository.UpdateStaff(staffTable);
                        }
                        else
                        {
                            staffRepository.InsertStaff(staffTable);
                        }
                    }
                }
                else
                { 
                    return View(staffModel);
                }
                return RedirectToAction("Technical");
            }
            catch (Exception)
            {
                return View(staffModel);
            }
        }
        public ActionResult Delete(int id = 0)
        {
            StaffTable staffTable = new StaffTable();
            if (id > 0)
            {
                staffRepository.DeleteStaff(id);
            }
            return RedirectToAction("Index");
        }

    }
}