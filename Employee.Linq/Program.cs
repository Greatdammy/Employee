using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee.Linq
{
    public class Program
    {
        static void Main()
        {
            var emp = new List<Employee>();
            emp.Add(new Employee { Id = 0001, Name = "Adekunle Victor", Age = 24, Gender = "Male", Salary = 150000 });
            emp.Add(new Employee { Id = 0002, Name = "Olabisi Esther ", Age = 21, Gender = "Female", Salary = 250000 });
            emp.Add(new Employee { Id = 0003, Name = "Adebimpe Morayo", Age = 20, Gender = "Female", Salary = 200000 });
            emp.Add(new Employee { Id = 0004, Name = "Obafemi Olaolu", Age = 26, Gender = "Male", Salary = 700000 });
            emp.Add(new Employee { Id = 0005, Name = "Nwafor Chisom", Age = 27, Gender = "Male", Salary = 250000 });
            emp.Add(new Employee { Id = 0006, Name = "Adeyemi Richard", Age = 29, Gender = "Male", Salary = 300000 });
            emp.Add(new Employee { Id = 0007, Name = "Lawal Victoria", Age = 22, Gender = "Feale", Salary = 100000 });
            emp.Add(new Employee { Id = 0008, Name = "Adeniyi Esther", Age = 21, Gender = "Female", Salary = 190000 });
            emp.Add(new Employee { Id = 0009, Name = "Bamidele Segun", Age = 30, Gender = "Male", Salary = 350000 });
            emp.Add(new Employee { Id = 0010, Name = "Olatunde Bukunmi", Age = 26, Gender = "Female", Salary = 500000 });


            var work = emp.Where(x => x.Age > 25)
                           .OrderByDescending(x => x.Age);

            foreach (var employee in work)
            {
                Console.WriteLine($"ID: {employee.Id} : Name:{employee.Name} Age: {employee.Age} : Gender: {employee.Gender} :" +
                    $"Salary: {employee.Salary}");
            }


            var work2 = emp.Where(x => x.Gender == "Female")
                           .OrderBy(x => x.Gender);

            Console.WriteLine();

            foreach(var employee in work2)
            {
                Console.WriteLine($"ID: {employee.Id} : Name:{employee.Name} Age: {employee.Age} : Gender: {employee.Gender} :" +
                    $"Salary: {employee.Salary}");
            }

            Console.WriteLine();

            var work3 = emp.Where(x => (x.Age == 20) || (x.Age == 30) || (x.Age == 35))
                           .OrderBy(x => x.Name);

            foreach(var employee in work3)
            {
                Console.WriteLine($"ID: {employee.Id} : Name:{employee.Name} Age: {employee.Age} : Gender: {employee.Gender} :" +
                    $"Salary: {employee.Salary}");
            }

            Console.WriteLine();


            var work4 = emp.Where(x => x.Id <= 0008 && x.Gender == "Female" )
                            .OrderBy(x => x.Gender == "Female"  );


            foreach(var employee in work4)
            {
                Console.WriteLine($"ID: {employee.Id} : Name:{employee.Name} Age: {employee.Age} : Gender: {employee.Gender} :" +
                    $"Salary: {employee.Salary}");
            }    


        }

       
    }

    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }   
        public string Gender { get; set; } 
        public double Salary { get; set; }  
    }
}
