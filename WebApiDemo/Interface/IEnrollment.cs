using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Interface
{
    public interface IEnrollment
    {
        void insert(Enrollment enrollment);
        Enrollment getById(int id);
        IEnumerable<Enrollment> getAll();
        void deleteById(int id);
    }
}
