using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public string Phone { get; set; }
        public Student()
        { 
        }

        public Student(int id, string name, double credits, string phone)
        {
            ID = id;
            Name = name;
            Credits = credits;
            Phone = phone;
        }
    }
}