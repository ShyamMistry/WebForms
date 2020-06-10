using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Employee()
        { 
        }

        public Employee(int id, string name, string phone)
        {
            ID = id;
            Name = name;
            Phone = phone;
        }
    }
}