using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Interface
{
    public interface ICourse
    {
        void insert(Course course);
        Course getById(int id);
        IEnumerable<Course> getAll();
        void deleteById(int id);
        Course update(Course course);
    }
}
