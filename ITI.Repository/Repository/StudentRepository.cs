using ITI.Data;
using ITI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Repository.Repository
{
    public class StudentRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public StudentRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<Student> GetStudents()
        {
            return iTIDataEntities.Students.ToList();
        }
        public Student GetStudentById(int id)
        {
            return iTIDataEntities.Students.FirstOrDefault(x => x.ID == id);
        }
        public Student InsertStudent(Student student)
        {
            var inserted = iTIDataEntities.Students.Add(student);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public Student UpdateStudent(Student student)
        {
            iTIDataEntities.Entry(student).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return student;
        }
        public void DeleteStudents(int id)
        {
            var student = iTIDataEntities.Students.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.Students.Remove(student);
            iTIDataEntities.SaveChanges();
        }
    }
}
