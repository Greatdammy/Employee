using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee.Linq
{
    public class Program
    {
        static void Main()
        {
            int[] evennumbers = { 2, 4, 4, 6, 8, 10, 12, 14, 16, 18, 19, 20, 8, 19, 11 };
            int [] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12};
            //string[] words = { "words", "all", "come", "those" };

            //Union

            var allnumber = evennumbers.Union(oddnumbers)
                                        .OrderBy(x => x);
            //                            .Sum(x => x);
            //Console.WriteLine(allnumber);
                                        
            

            var numbers = evennumbers.Where(x => x > 10)
                                        .Union(evennumbers.Where(x => x < 10));


            foreach (var i in allnumber)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            //Intersect
            var queuenumber = evennumbers.Intersect(oddnumbers)
                                          .OrderBy(x => x);
            
            foreach(var i in queuenumber)
            {
                Console.WriteLine($"Intersect: {i}");
            }

            Console.WriteLine();

            //Except

            var exceptnumber = oddnumbers.Except(evennumbers);
            foreach(var i in exceptnumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            //Distict

            var distinctnumber = evennumbers.Distinct();
            foreach(var i in distinctnumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            //sum 
             var sumnumbers = evennumbers.Where(x => x < 20)
                                           .Sum(x => x);
            Console.WriteLine($"Sumnumbers: {sumnumbers}");

            Console.WriteLine();


            //min
            var number = oddnumbers.Min(x => x);
            Console.WriteLine(number);

            Console.WriteLine();

            //max

            var num = evennumbers.Max(x => x);
            Console.WriteLine(num);
            Console.WriteLine();

            //average 

            var num1 = evennumbers.Average(x => x);
            Console.WriteLine(num1);


                Console.WriteLine();

            //Aggregate 
             var aggsum = evennumbers.Aggregate((a, b) => a + b);
            Console.WriteLine(aggsum);
           

            //


         

        }
    }
}
