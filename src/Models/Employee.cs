﻿using System;
namespace ASPNet_Test.Models
{
    public class Employee
    {
        public Employee()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
