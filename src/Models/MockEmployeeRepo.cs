using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNet_Test.Models
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        private List<Employee> _empList;
        public MockEmployeeRepo()
        {
            _empList = new List<Employee>();
            _empList.Add(new Employee { Id = 1, Name = "John Doe", Department = "Sales" });
            _empList.Add(new Employee { Id = 2, Name = "Jane Smith", Department = "Marketing" });
            _empList.Add(new Employee { Id = 3, Name = "Mike Johnson", Department = "Finance" });
            _empList.Add(new Employee { Id = 4, Name = "Emily Davis", Department = "Human Resources" });
            _empList.Add(new Employee { Id = 5, Name = "Chris Wilson", Department = "Operations" });

        }

        public Employee GetEmployee(int id)
        {
            return _empList.FirstOrDefault(e => e.Id == id);
        }
    }
}
