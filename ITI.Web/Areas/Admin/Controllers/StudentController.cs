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
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;
        public StudentController()
        {
            studentRepository = new StudentRepository();
        }
        // GET: Admin/Student 
        public ActionResult Index()
        {
            var students = studentRepository.GetStudents().Select(x => new StudentModel { ID = x.ID, Name = x.Name, FatherName = x.FatherName, DateofBirth = x.DateofBirth });
            return View(students);
        }
        public ActionResult Create(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
                student = studentRepository.GetStudentById(id);
            }
            ViewBag.Category = StaticData.GetCategories();
            ViewBag.Trade = StaticData.GetTrade();
            ViewBag.Unit = StaticData.GetUnit();
            ViewBag.Session = StaticData.GetSession();
            StudentModel studetModel = new StudentModel
            {
                ID = student.ID,
                Name = student.Name,
                FatherName = student.FatherName,
                EnrollNo = student.EnrollNo,
                Category = student.Category,
                Trade = student.Trade,
                Unit = student.Unit,
                DateofBirth = student.DateofBirth,
                Session = student.Session,
                Qualification = student.Qualification,
                DateofAddmission = student.DateofAddmission
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
                    EnrollNo = studentModel.EnrollNo,
                    Category = studentModel.Category,
                    Trade = studentModel.Trade,
                    Unit = studentModel.Unit,
                    DateofBirth = studentModel.DateofBirth,
                    Session = studentModel.Session,
                    Qualification = studentModel.Qualification,
                    DateofAddmission = studentModel.DateofAddmission
                };
                if (ModelState.IsValid)
                {
                    if (student.ID > 0)
                    {
                        studentRepository.UpdateStudent(student);
                    }
                    else
                    {
                        studentRepository.InsertStudent(student);
                    }
                }
                else
                {

                    ViewBag.Category = StaticData.GetCategories();
                    ViewBag.Trade = StaticData.GetTrade();
                    ViewBag.Unit = StaticData.GetUnit();
                    ViewBag.Session = StaticData.GetSession();
                    return View(studentModel);
                }


                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(studentModel);
            }
        }

        public ActionResult Delete(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
                studentRepository.DeleteStudents(id);
            }
            return RedirectToAction("Index");
        }
    }
}