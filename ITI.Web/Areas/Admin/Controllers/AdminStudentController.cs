using ITI.Models;
using ITI.Web.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Areas.Admin.Controllers
{
    public class AdminStudentController : Controller
    {
        protected MgttcEntities mgttcEntities;
        public AdminStudentController()
        {
            mgttcEntities = new MgttcEntities();
        }
        public ActionResult StudentCreate(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
                student = mgttcEntities.Students.FirstOrDefault(x => x.ID == id);
            }
            StudentModel studetModel = new StudentModel
            {
                ID = student.ID,
                FatherName = student.FatherName, 
                Category = student.Category,
                Session = student.Session, 
                MotherName = student.MotherName 
            };
            return View(studetModel);
        } 
        [HttpPost]
        public ActionResult StudentCreate(StudentModel studentModel)
        {
            try
            {
                Student student = new Student
                {
                    ID = studentModel.ID,
                    FatherName = studentModel.FatherName, 
                    Category = studentModel.Category,
                    Session = studentModel.Session, 
                    MotherName = studentModel.MotherName 
                };
                if (ModelState.IsValid)
                {
                    if (student.ID > 0)
                    {
                        mgttcEntities.Entry(student).State = EntityState.Modified;
                        mgttcEntities.SaveChanges();
                    }
                    else
                    {
                        mgttcEntities.Students.Add(student);
                        mgttcEntities.SaveChanges();
                    }
                }
                else
                {
                    return View(studentModel);
                }


                return RedirectToAction("StudentList");
            }
            catch (Exception)
            {
                return View(studentModel);
            }
        }
        public ActionResult Index()
        {
            var student = mgttcEntities.Students.Select(x => new StudentModel { ID = x.ID, Category = x.Category, FatherName = x.FatherName,  MotherName = x.MotherName, Session = x.Session});
            return View(student);
        } 
       
        public ActionResult DeleteStudent(int id = 0)
        {
            Staff staff = new Staff();
            if (id > 0)
            {
                var student = mgttcEntities.Students.FirstOrDefault(x => x.ID == id); 
                mgttcEntities.Students.Remove(student);
                mgttcEntities.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}