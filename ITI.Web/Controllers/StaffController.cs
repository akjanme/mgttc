using ITI.Web.Data;
using ITI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ITI.Web.Controllers
{
    public class StaffController : Controller
    {
        protected MgttcEntities mgttcEntities;
        public StaffController()
        {
            mgttcEntities = new MgttcEntities();
        }
        public ActionResult Index()
        {
            IEnumerable<StaffModel> staff = from x in mgttcEntities.Staffs
                                            select new StaffModel
                                            {
                                                ID = x.ID,
                                                Name = x.Name,
                                                DateOfBirth = x.DateOfBirth,
                                                DateOfJoin = x.DateOfJoin,
                                                Designation = x.Designation,
                                                Category = x.Category,
                                                Experience = x.Experience,
                                                B_Ed_Marks = x.B_Ed_Marks,
                                                M_Ed_Marks = x.M_Ed_Marks,
                                                MA_Marks = x.MA_Marks,
                                                Masters_Marks = x.Masters_Marks,
                                                TeachingSubject = x.TeachingSubject,
                                                Has_Phed = x.Has_Phed,
                                                Has_UGC_Net = x.Has_UGC_Net,
                                                PhotoGraph = x.PhotoGraph,
                                                StaffType = x.StaffType
                                            };
            return View(staff);
        }

        public ActionResult AddStaff(int id = 0)
        {
            Staff Staff = new Staff();
            if (id > 0)
            {
                Staff = mgttcEntities.Staffs.FirstOrDefault((Staff x) => x.ID == id);
            }
            StaffModel staffModel = new StaffModel
            {
                ID = Staff.ID,
                Name = Staff.Name,
                DateOfBirth = Staff.DateOfBirth,
                DateOfJoin = Staff.DateOfJoin,
                Designation = Staff.Designation,
                Category = Staff.Category,
                Experience = Staff.Experience,
                B_Ed_Marks = Staff.B_Ed_Marks,
                M_Ed_Marks = Staff.M_Ed_Marks,
                MA_Marks = Staff.MA_Marks,
                Masters_Marks = Staff.Masters_Marks,
                TeachingSubject = Staff.TeachingSubject,
                Has_Phed = Staff.Has_Phed,
                Has_UGC_Net = Staff.Has_UGC_Net,
                PhotoGraph = Staff.PhotoGraph,
                StaffType = Staff.StaffType
            };
            return View(staffModel);
        }

        [HttpPost]
        public ActionResult AddStaff(StaffModel staffModel)
        {
            try
            {
                if (base.ModelState.IsValid)
                {
                    Staff staff = new Staff
                    {
                        ID = staffModel.ID,
                        Name = staffModel.Name,
                        DateOfBirth = staffModel.DateOfBirth,
                        DateOfJoin = staffModel.DateOfJoin,
                        Designation = staffModel.Designation,
                        Category = staffModel.Category,
                        Experience = staffModel.Experience,
                        B_Ed_Marks = staffModel.B_Ed_Marks,
                        M_Ed_Marks = staffModel.M_Ed_Marks,
                        MA_Marks = staffModel.MA_Marks,
                        Masters_Marks = staffModel.Masters_Marks,
                        TeachingSubject = staffModel.TeachingSubject,
                        Has_Phed = staffModel.Has_Phed,
                        Has_UGC_Net = staffModel.Has_UGC_Net,
                        StaffType = staffModel.StaffType,
                        PhotoGraph = staffModel.PhotoGraph
                    };
                    if (staffModel.FileName != null && staffModel.FileName.ContentLength > 0)
                    {
                        string _PhotoName = Path.GetFileName(staff.Name + "_" + staffModel.FileName.FileName).Replace(" ", "");
                        string _path = Path.Combine(base.Server.MapPath("~/images/staff"), _PhotoName);
                        staff.PhotoGraph = _PhotoName;
                        staffModel.FileName.SaveAs(_path);
                    }
                    if (staff.ID > 0)
                    {
                        mgttcEntities.Entry(staff).State = EntityState.Modified;
                    }
                    else
                    {
                        mgttcEntities.Staffs.Add(staff);
                    }
                    mgttcEntities.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(staffModel);
            }
            catch (Exception)
            {
                return View(staffModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            if (id > 0)
            {
                Staff staff = mgttcEntities.Staffs.FirstOrDefault((Staff x) => x.ID == id);
                if (!string.IsNullOrEmpty(staff.PhotoGraph) && System.IO.File.Exists(Path.Combine(base.Server.MapPath("~/images/staff"), staff.PhotoGraph)))
                {
                    System.IO.File.Delete(Path.Combine(base.Server.MapPath("~/images/staff"), staff.PhotoGraph));
                }
                mgttcEntities.Staffs.Remove(staff);
                mgttcEntities.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }

}