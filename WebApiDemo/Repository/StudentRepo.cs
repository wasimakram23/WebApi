using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Interface;
using WebApiDemo.Models;
using WebApiDemo.DAL;

namespace WebApiDemo.Repository
{
    public class StudentRepo : IStudent
    {
        private readonly VersityContext _dbcontext;
        public StudentRepo(VersityContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void deleteById(int id)
        {
            var student = _dbcontext.Students.Where(i => i.ID == id).First();
            if (student != null)
            {
                _dbcontext.Students.Remove(student);
                _dbcontext.SaveChanges();
            }
        }

        public IEnumerable<Student> getAll()
        {
            return _dbcontext.Students.ToList();
        }

        public Student getById(int id)
        {
            return _dbcontext.Students.Where(i => i.ID == id).FirstOrDefault();
        }

        public void insert(Student student)
        {
            _dbcontext.Students.Add(student);
            _dbcontext.SaveChanges();
        }

        public Student update(Student student)
        {
            var _student = _dbcontext.Students.Where(i => i.ID == student.ID).FirstOrDefault();
            if (_student != null)
            {
                _student.LastName = student.LastName;
                _student.FirstMidName = student.FirstMidName;
                _student.EnrollmentDate = student.EnrollmentDate;
                _dbcontext.SaveChanges();
            }
            return _student;
        }
    }
}