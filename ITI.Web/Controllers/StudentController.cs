using ITI.Web.Data;
using ITI.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ITI.Web.Controllers
{
    public class StudentController : Controller
    {  
        MgttcEntities mgttcEntities;
        public StudentController()
        {
            mgttcEntities = new MgttcEntities();
        }
        public ActionResult Index()
        {
            IEnumerable<StudentModel> students = from x in mgttcEntities.Students
                                                 select new StudentModel
                                                 {
                                                     ID = x.ID,
                                                     Name = x.Name,
                                                     FatherName = x.FatherName,
                                                     MotherName = x.MotherName,
                                                     Category = x.Category,
                                                     DateOfAdmit = x.DateOfAdmit,
                                                     Percentage = x.Percentage,
                                                     Session = x.Session,
                                                     Qualification = x.Qualification,
                                                     Ptet_Per = x.Ptet_Per
                                                 };
            return View(students);
        }

        public ActionResult Create(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
                student = mgttcEntities.Students.FirstOrDefault(x=>x.ID==id);
            }
            base.ViewBag.Category = StaticData.GetCategories();
            base.ViewBag.Session = StaticData.GetSession();
            StudentModel studetModel = new StudentModel
            {
                ID = student.ID,
                Name = student.Name,
                FatherName = student.FatherName,
                MotherName = student.MotherName,
                Category = student.Category,
                DateOfAdmit = student.DateOfAdmit,
                Percentage = student.Percentage,
                Session = student.Session,
                Qualification = student.Qualification,
                Ptet_Per = student.Ptet_Per
            };
            return View(studetModel);
        }

        [HttpPost]
        public ActionResult Create(StudentModel studentModel)
        {
            try
            {
                Student student = new Student
                {
                    ID = studentModel.ID,
                    Name = studentModel.Name,
                    FatherName = studentModel.FatherName,
                    MotherName = studentModel.MotherName,
                    Category = studentModel.Category,
                    DateOfAdmit = studentModel.DateOfAdmit,
                    Percentage = studentModel.Percentage,
                    Session = studentModel.Session,
                    Qualification = studentModel.Qualification,
                    Ptet_Per = studentModel.Ptet_Per
                };
                if (base.ModelState.IsValid)
                {
                    if (student.ID > 0)
                    { 
                        mgttcEntities.Entry(student).State = EntityState.Modified;
                    }
                    else
                    {
                        mgttcEntities.Students.Add(student);
                    }
                    mgttcEntities.SaveChanges();
                    return RedirectToAction("Index");
                }
                base.ViewBag.Category = StaticData.GetCategories();
                base.ViewBag.Session = StaticData.GetSession();
                return View(studentModel);
            }
            catch (Exception)
            {
                return View(studentModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            new Student();
            if (id > 0)
            { 
                Student student = mgttcEntities.Students.FirstOrDefault((Student x) => x.ID == (long)id);
                mgttcEntities.Students.Remove(student);
                mgttcEntities.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}