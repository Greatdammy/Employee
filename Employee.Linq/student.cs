﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Linq
{
    public  class Student
    {
        public int RollNo { get; set; } 
        public string Name { get; set; }    
        public int Standard { get; set; }   
        public Gender Gender { get; set; }

        public static List<Student> GetClasses()
        {
            return new List<Student>
            {
                new Student { RollNo = 101, Name = "Thomas", Gender = Gender.Male,    Standard = 10},
                new Student { RollNo = 102, Name = "Olaolu", Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 103, Name = "Chris",  Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 104, Name = "Funmi",  Gender = Gender.Female,  Standard = 10},
                new Student { RollNo = 105, Name = "Ron",    Gender = Gender.Male,    Standard = 7},
                new Student { RollNo = 106, Name = "Jimi",   Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 107, Name = "Kate",   Gender = Gender.Female,  Standard = 5},
                new Student { RollNo = 108, Name = "John",   Gender = Gender.Male,    Standard = 6},
                new Student { RollNo = 109, Name = "Ema",    Gender = Gender.Female,  Standard = 6},
                new Student { RollNo = 110, Name = "Ravi",   Gender = Gender.Male, },

            };
        }
    }
    public enum Gender
    {
        Female, 
        Male ,
    }

    public class Standard
    {
        public int id { get; set; }
        public string ClassTeacher { get; set; }
        public double Fees { get; set; }    


        public static List<Standard>  GetStandard()
        {
            return new List<Standard>
            {
                new Standard { id = 10, ClassTeacher = "Max", Fees = 100.000},
                new Standard { id = 8, ClassTeacher = "Ajayi", Fees = 800.000},
                new Standard { id = 6, ClassTeacher = "Geeta", Fees = 600.000},
                new Standard { id = 4, ClassTeacher = "Rohan", Fees = 400.00}
            };

        }
    }

}
