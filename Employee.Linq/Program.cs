using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee.Linq
{
    public class Program
    {
        static void Main()
        {
            var Student = student.GetStudents();   
            int[] evennumbers = { 2, 4, 4, 6, 8, 10, 12, 14, 16, 18, 19, 20, 8, 19, 11 };
            int [] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12};
            int[] onenumbers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            string[] words = { "chalk", "Pencil", "marker" };

            ////Union

            //var allnumber = evennumbers.Union(oddnumbers)
            //                            .OrderBy(x => x);
            ////                            .Sum(x => x);
            ////Console.WriteLine(allnumber);



            //var numbers = evennumbers.Where(x => x > 10)
            //                            .Union(evennumbers.Where(x => x < 10));


            //foreach (var i in allnumber)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine();
            ////Intersect
            //var queuenumber = evennumbers.Intersect(oddnumbers)
            //                              .OrderBy(x => x);

            //foreach(var i in queuenumber)
            //{
            //    Console.WriteLine($"Intersect: {i}");
            //}

            //Console.WriteLine();

            ////Except

            //var exceptnumber = oddnumbers.Except(evennumbers);
            //foreach(var i in exceptnumber)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            //Distict

            //var distinctnumber = evennumbers.Distinct();
            //foreach(var i in distinctnumber)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            //sum 
            // var sumnumbers = evennumbers.Where(x => x < 20)
            //                               .Sum(x => x);
            //Console.WriteLine($"Sumnumbers: {sumnumbers}");

            //Console.WriteLine();


            //min
            //var number = oddnumbers.Min(x => x);
            //Console.WriteLine(number);

            //Console.WriteLine();

            //max

            //var num = evennumbers.Max(x => x);
            //Console.WriteLine(num);
            //Console.WriteLine();

            //average 

            //var num1 = evennumbers.Average(x => x);
            //Console.WriteLine(num1);


            //    Console.WriteLine();

            //Aggregate 
            // var aggsum = evennumbers.Aggregate((a, b) => a + b);
            //Console.WriteLine(aggsum);


            // ELEMENT OPERATORS

            //first or FirstOrDefault
            //var numbers = evennumbers.FirstOrDefault();
            //Console.WriteLine(numbers);
            //Console.WriteLine();

            //Last or lastordefault 

            //var allodds = oddnumbers.LastOrDefault();
            //Console.WriteLine(allodds);

            //Console.WriteLine();

            //single or SingleOrDefault
            //var all = oddnumbers.SingleOrDefault(x => x > 18);
            //Console.WriteLine(all);



            //Quantifiers
            //Any
            var numbers = oddnumbers.Any(x => x == 3);
            Console.WriteLine(numbers);

            var keyword = words.Any(x => x == "Marker");
            Console.WriteLine(keyword);

            //All
             var newnumbers = onenumbers.All(x => x == 9);
            Console.WriteLine(newnumbers);

            //select many

            var items = Student.SelectMany(x => x.course,
                                            (studentsname, dept) => new
                                            {
                                                newstudentname = studentsname.name,
                                                Course = dept
                                                });
            foreach(var item in items)
            {
                Console.WriteLine($"{item.Course} : {item.newstudentname}");
            }

            Console.WriteLine();
            var product = Student.ToDictionary<student, int>(s => s.ID);
            foreach(var item in product.Keys)
            {
                Console.WriteLine("key {0} value {1}", item, product[item].ID);
            }

         

        }
    }
    public class student
    {
        public string name { get; set; }
        public string place { get; set; }
        public List<string> course { get; set; }
        public int ID {get; set; }

        public static List<student> GetStudents()
        {
            return new List<student>
            {
                new student { ID = 1, name = "John", place = "Lagos", course = new List<String>(){"biology", "chemistry", "maths" } },
                new student { ID = 2, name = "Edward", place = "Ibadan", course = new List<string>(){"chem104", "bio101", "bam106" } },
                new student { ID = 3, name = "Ali", place = "Jos", course = new List<string>(){"chem404", "bio401", "bam206" } },
            };
        }
    }
}
