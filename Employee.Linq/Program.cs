using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee.Linq
{
    public class Program
    {
        static void Main()
        {
            var allstudent = Student.GetClasses();
            var teacher = Standard.GetStandard();

            //GroupJoin
            //var data = from d in teacher
            //           join c in allstudent
            //           on d.id equals c.Standard into groupedteacher
            //           select new
            //           {
            //               d.id,
            //               d.ClassTeacher,
            //               groupedteacher
            //           };
            //foreach(var item in data)
            //{
            //    Console.WriteLine($"Name: {item.ClassTeacher} : Id: {item.id}");
            //    foreach(var itempro in item.groupedteacher)
            //    {
            //        Console.WriteLine($"----{itempro.Name}------{itempro.RollNo}");
            //    }
            //}


            //Left outer join
            var datas = from d in teacher
                        join c in allstudent
                        on d.id equals c.Standard into groupedstdent
                        from g in groupedstdent.DefaultIfEmpty()
                        select new
                        {
                            d.id,
                            d.ClassTeacher,
                            Classstdent = g == null ? "no student" : g.Name,
                            classnumber = g == null ? 0 : g.RollNo
                        };
            foreach(var item in datas)
            {
                Console.WriteLine($"Name: {item.ClassTeacher}: Id: {item.id} RollNumber: {item.classnumber} classname: {item.Classstdent}");
            }



            //extension method based (group join) syntax
           //var newdata = allstudent.GroupJoin(teacher,
           //                         b => b.Standard,
           //                         x => x.id, (bt, groupedteacher) => new
           //                         {
           //                             studentname = bt.Name,
           //                             Id = bt.Standard,
           //                            Gender = bt.Gender,
           //                             groupedteacher
           //                         });

           // foreach (var item in newdata)
           // {
           //     Console.WriteLine($"Name: {item.studentname} : Id: {item.Id} : Gender: {item.Gender} ");
           //     foreach (var itempro in item.groupedteacher)
           //     {
           //         Console.WriteLine($"----{itempro.ClassTeacher}------{itempro.id}");
           //     }
           // }
            /**  //Query syntax
              var data = from b in allstudent
                         join x in teacher
                         on b.Standard equals x.id
                         select new
                         {
                             b.Name,
                             x.ClassTeacher,
                             x.id,
                             b.Gender
                         };

              //Extention method/BasedSyntax
              var newdata = allstudent.Join(teacher,
                                          b => b.Standard,
                                          x => x.id, (bt, x1) => new
                                          {
                                              bt.Name,
                                              x1.ClassTeacher,
                                              bt.Standard,
                                              bt.Gender,
                                              x1.Fees

                                          }).Where(b => b.Standard > 6)
                                            .OrderByDescending(x => x.Fees);



              foreach(var alldata in newdata)
              {
                  Console.WriteLine($"StudentName {alldata.Name}: Teacher: {alldata.ClassTeacher} ID: {alldata.Standard}");
              }*/
        }
    } 
}
