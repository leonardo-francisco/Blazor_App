using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class EmployeeService
    {
        private readonly AppDbContext _db;

        public EmployeeService(AppDbContext db)
        {
            _db = db;
        }

        //FOR CRUD OPERATION
        public List<Employee> GetEmployee()
        {
            var empList = _db.Employee.ToList();
            return empList;
        }

        public string Create(Employee emp)
        {
            _db.Employee.Add(emp);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = _db.Employee.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }

        public string UpdateEmployee(Employee emp)
        {
            _db.Employee.Update(emp);
            _db.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteEmployee(Employee emp)
        {
            _db.Employee.Remove(emp);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
