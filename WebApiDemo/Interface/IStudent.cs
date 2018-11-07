
using System.Collections.Generic;
using WebApiDemo.Models;

namespace WebApiDemo.Interface
{
    public interface IStudent
    {
        void insert(Student student);
        Student getById(int id);
        IEnumerable<Student> getAll();
        void deleteById(int id);
        Student update(Student student);
    }
}
