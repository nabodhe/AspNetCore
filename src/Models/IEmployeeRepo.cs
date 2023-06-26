using System;
namespace ASPNet_Test.Models
{
    public interface IEmployeeRepo
    {
        Employee GetEmployee(int id);
    }
}
