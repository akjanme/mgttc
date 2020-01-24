using ITI.Data;
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
        protected MGTTCEntities mGTTCEntities;

        public StudentRepository()
        {
            mGTTCEntities = new MGTTCEntities();
        }

        public List<Student> GetStudents()
        {
            return mGTTCEntities.Students.ToList();
        }
        public Student GetStudentById(int id)
        {
            return mGTTCEntities.Students.FirstOrDefault(x => x.ID == id);
        }
        public Student InsertStudent(Student student)
        {
            var inserted = mGTTCEntities.Students.Add(student);
            mGTTCEntities.SaveChanges();
            return inserted;
        }
        public Student UpdateStudent(Student student)
        {
            mGTTCEntities.Entry(student).State = EntityState.Modified;
            mGTTCEntities.SaveChanges();
            return student;
        }
        public void DelectStudents(int id)
        {
            var student = mGTTCEntities.Students.FirstOrDefault(x => x.ID == id);
            mGTTCEntities.Students.Remove(student);
            mGTTCEntities.SaveChanges();
        }
    }
}
