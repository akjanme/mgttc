using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITI.Data;
using ITI.Models;
using ITI.Repository.Repository;

namespace ITI.Web.Areas.Admin.Controllers
{
    public class AStaffStundentController : Controller
    {
        private readonly StaffRepository staffRepository;
        private readonly StudentRepository studentRepository;
        public AStaffStundentController()
        {
            staffRepository = new StaffRepository();
            studentRepository = new StudentRepository();
        }
        // GET: Admin/AStaffStundent
        public ActionResult StaffCreate(int id = 0)
        {
            Staff staff = new Staff();
            if (id > 0)
            {
                staff = staffRepository.GetStaffById(id);
            }
            StaffModel staffModel =new StaffModel
            {
                ID = staff.ID,
                AadharNumber=staff.AadharNumber,
                DateOfBirth=staff.DateOfBirth,
                DateOfJoin=staff.DateOfJoin,
                Salary=staff.Salary,
                StaffName=staff.StaffName,
                StaffType=staff.StaffType,
                Subject=staff.Subject,
                SubjectNumFirst=staff.SubjectNumFirst,
                SubjectNumSecond=staff.SubjectNumSecond,
                TeachSubFirst=staff.TeachSubFirst,
                TeachSubSecond=staff.TeachSubSecond,
                Designation=staff.Designation,
                Experience=staff.Experience,
                FatherName=staff.FatherName,
                PanNumber=staff.PanNumber
            };
            return View(staffModel);
        }
        public ActionResult StudentCreate(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
                student = studentRepository.GetStudentById(id);
            }
            StudentModel studetModel = new StudentModel
            {
                ID = student.ID,
                FatherName = student.FatherName,
                Dob = student.Dob,
                Category = student.Category,
                Session = student.Session,
                Sname = student.Sname,
                SubCategory = student.SubCategory,
                Faculty = student.Faculty,
                Gender = student.Gender,
                MobileNo = student.MobileNo,
                MotherName = student.MotherName,
                RollNo = student.RollNo
            };
            return View(studetModel); 
        }
        [HttpPost]
        public ActionResult StaffCreate(StaffModel staffModel)
        {
            try
            {
                Staff staff = new Staff
                {
                    ID = staffModel.ID,
                    AadharNumber = staffModel.AadharNumber,
                    DateOfBirth = staffModel.DateOfBirth,
                    DateOfJoin = staffModel.DateOfJoin,
                    Salary = staffModel.Salary,
                    StaffName = staffModel.StaffName,
                    StaffType = staffModel.StaffType,
                    Subject = staffModel.Subject,
                    SubjectNumFirst = staffModel.SubjectNumFirst,
                    SubjectNumSecond = staffModel.SubjectNumSecond,
                    TeachSubFirst = staffModel.TeachSubFirst,
                    TeachSubSecond = staffModel.TeachSubSecond,
                    Designation = staffModel.Designation,
                    Experience = staffModel.Experience,
                    FatherName = staffModel.FatherName,
                    PanNumber = staffModel.PanNumber
                };
                if (ModelState.IsValid)
                {
                    if (staff.ID > 0)
                    {
                        staffRepository.InsertStaff(staff);
                    }
                    else
                    {
                        staffRepository.UpdateStaff(staff);
                    }
                }
                else
                {
                    return View(staffModel);
                }


                return RedirectToAction("TeachingSatff");
            }
            catch (Exception)
            {
                return View(staffModel);
            }
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
                    Dob = studentModel.Dob,
                    Category = studentModel.Category,
                    Session = studentModel.Session,
                    Sname = studentModel.Sname,
                    SubCategory = studentModel.SubCategory,
                    Faculty = studentModel.Faculty,
                    Gender = studentModel.Gender,
                    MobileNo = studentModel.MobileNo,
                    MotherName = studentModel.MotherName,
                    RollNo = studentModel.RollNo
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
                    return View(studentModel);
                }


                return RedirectToAction("StudentList");
            }
            catch (Exception)
            {
                return View(studentModel);
            }
        }
        public ActionResult TeachingStaff()
        {
            var tech = staffRepository.GetStaffs().Select(x => new StaffModel { ID = x.ID, AadharNumber = x.AadharNumber, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, FatherName = x.FatherName, PanNumber = x.PanNumber, Salary = x.Salary, StaffName = x.StaffName, StaffType = x.StaffType, Subject = x.Subject, SubjectNumFirst = x.SubjectNumFirst, SubjectNumSecond = x.SubjectNumSecond, TeachSubFirst = x.TeachSubFirst, TeachSubSecond = x.TeachSubSecond });
            return View(tech);
        }
        public ActionResult NonTeachingStaff()
        {
            var nontech = staffRepository.GetStaffs().Select(x => new StaffModel { ID = x.ID, AadharNumber = x.AadharNumber, DateOfBirth = x.DateOfBirth, DateOfJoin = x.DateOfJoin, Designation = x.Designation, Experience = x.Experience, FatherName = x.FatherName, PanNumber = x.PanNumber, Salary = x.Salary, StaffName = x.StaffName, StaffType = x.StaffType, Subject = x.Subject, SubjectNumFirst = x.SubjectNumFirst, SubjectNumSecond = x.SubjectNumSecond, TeachSubFirst = x.TeachSubFirst, TeachSubSecond = x.TeachSubSecond });
            return View(nontech);
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
        public ActionResult DeleteStaff(int id = 0)
        {
            Student student = new Student();
            if (id > 0)
            {
               studentRepository.DelectStudents(id);
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStudent(int id = 0)
        {
            Staff staff = new Staff();
            if (id > 0)
            {
                staffRepository.DelectStaffs(id);
            }
            return RedirectToAction("Index");
        }
    }
}