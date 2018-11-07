using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Interface;
using WebApiDemo.Models;
using WebApiDemo.DAL;

namespace WebApiDemo.Repository
{
    public class EnrollmentRepo : IEnrollment
    {
        private readonly VersityContext _dbcontext;
        public EnrollmentRepo(VersityContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void deleteById(int id)
        {
            var enrollment = _dbcontext.Enrollments.Where(i => i.EnrollmentID == id).FirstOrDefault();
            if (enrollment != null)
            {
                _dbcontext.Enrollments.Remove(enrollment);
                _dbcontext.SaveChanges();
            }
        }

        public IEnumerable<Enrollment> getAll()
        {
            return _dbcontext.Enrollments.ToList();
        }

        public Enrollment getById(int id)
        {
            return _dbcontext.Enrollments.Where(i => i.EnrollmentID == id).FirstOrDefault();
        }

        public void insert(Enrollment enrollment)
        {
            _dbcontext.Enrollments.Add(enrollment);
        }
    }
}