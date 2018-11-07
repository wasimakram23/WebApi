using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Interface;
using WebApiDemo.Models;
using WebApiDemo.DAL;

namespace WebApiDemo.Repository
{
    public class CourseRepo : ICourse
    {
        private readonly VersityContext _dbcontext;
        public CourseRepo(VersityContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void deleteById(int id)
        {
            var course = _dbcontext.Courses.Where(i => i.CourseID == id).FirstOrDefault();
            if (course != null)
            {
                _dbcontext.Courses.Remove(course);
                _dbcontext.SaveChanges();
            }
        }

        public IEnumerable<Course> getAll()
        {
           return _dbcontext.Courses.ToList();
        }

        public Course getById(int id)
        {
            return _dbcontext.Courses.Where(i => i.CourseID == id).FirstOrDefault();
        }

        public void insert(Course course)
        {
            _dbcontext.Courses.Add(course);
        }

        public Course update(Course course)
        {
            var _course = _dbcontext.Courses.Where(i=>i.CourseID==course.CourseID).FirstOrDefault();
            if (_course != null)
            {
                _course.Credits = course.Credits;
                _course.Title = course.Title;
                _dbcontext.SaveChanges();
            }
            return _course;
        }
    }
}