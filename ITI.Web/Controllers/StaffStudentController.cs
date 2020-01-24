using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;

namespace ITI.Web.Controllers
{
    public class StaffStudentController : Controller
    {
        private readonly StaffRepository staffRepository;
        private readonly StudentRepository studentRepository;
        // GET: SataffStudent
        public StaffStudentController()
        {
            staffRepository = new StaffRepository();
            studentRepository = new StudentRepository();
        }
        public ActionResult NonTeachingStaff()
        {
            var nontech = staffRepository.GetStaffs().Select(x => new StaffModel { ID = x.ID, AadharNumber = x.AadharNumber, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, FatherName = x.FatherName, PanNumber = x.PanNumber, Salary = x.Salary, StaffName = x.StaffName, StaffType = x.StaffType, Subject = x.Subject, SubjectNumFirst = x.SubjectNumFirst, SubjectNumSecond = x.SubjectNumSecond, TeachSubFirst = x.TeachSubFirst, TeachSubSecond = x.TeachSubSecond });
            return View(nontech);
        }
        public ActionResult TeachingStaff()
        {
            var tech = staffRepository.GetStaffs().Select(x => new StaffModel { ID = x.ID, AadharNumber = x.AadharNumber, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, FatherName = x.FatherName, PanNumber = x.PanNumber, Salary = x.Salary, StaffName = x.StaffName, StaffType = x.StaffType, Subject = x.Subject, SubjectNumFirst = x.SubjectNumFirst, SubjectNumSecond = x.SubjectNumSecond, TeachSubFirst = x.TeachSubFirst, TeachSubSecond = x.TeachSubSecond });
            return View(tech);
        }
        public ActionResult StudentList()
        {
            var student = studentRepository.GetStudents().Select(x => new StudentModel { ID = x.ID, Category = x.Category, Dob = x.Dob, Faculty = x.Faculty, FatherName = x.FatherName, Gender = x.Gender, MobileNo = x.MobileNo, MotherName = x.MotherName, RollNo = x.RollNo, Session = x.Session, Sname = x.Sname, SubCategory = x.SubCategory });
            return View(student);
        }
        public ActionResult FacultyOfEducation()
        {
            return View();
        }
        public ActionResult StudentCategory()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }
    }
}