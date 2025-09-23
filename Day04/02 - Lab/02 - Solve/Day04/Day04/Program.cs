using Day04._01___Find___List_Extension_Method;
using Day04._02___Event_Task;
using System.Runtime.Intrinsics.X86;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01 - MyFind() List Extension Method

            //List<string> strings = new List<string>() { "eslam", "ahmed", "khalid", "omar", "rana", "ali", "mane" };

            #region 01.1 - Call MyFind() As Class Member Method

            ////Find stringsMoreThan3 =>
            //var stringsMoreThan3 = ListExtension.MyFind(strings, (x) => x.Length > 3);

            //Console.WriteLine("======= stringsMoreThan3 =======");
            //foreach (var item in stringsMoreThan3)
            //{
            //    Console.Write($"{item} ");//eslam ahmed khalid omar rana
            //}

            ////Find stringsStartWith_a =>
            //var stringsStartWith_a = ListExtension.MyFind(strings, (x) => x[0] == 'a');

            //Console.WriteLine("\n\n======= stringsStartWith_a =======");
            //foreach (var item in stringsStartWith_a)
            //{
            //    Console.Write($"{item} ");//ahmed ali
            //}

            ////Find stringsStartWith_a =>
            //var stringsEndtWith_e = ListExtension.MyFind(strings, (x) => x[x.Length - 1] == 'e');

            //Console.WriteLine("\n\n======= stringsEndtWith_e =======");
            //foreach (var item in stringsEndtWith_e)
            //{
            //    Console.Write($"{item} ");//mane
            //} 

            #endregion

            #region 01.2 - Call MyFind() As object Member Method

            ////Find stringsMoreThan3 =>
            //var stringsMoreThan3_ = strings.MyFind((x) => x.Length > 3);

            //Console.WriteLine("\n\n======= stringsMoreThan3 =======");
            //foreach (var item in stringsMoreThan3_)
            //{
            //    Console.Write($"{item} ");//eslam ahmed khalid omar rana
            //}

            ////Find stringsStartWith_a =>
            //var stringsStartWith_a_ = strings.MyFind((x) => x[0] == 'a');

            //Console.WriteLine("\n\n======= stringsStartWith_a =======");
            //foreach (var item in stringsStartWith_a_)
            //{
            //    Console.Write($"{item} ");//ahmed ali
            //}

            ////Find stringsStartWith_a =>
            //var stringsEndtWith_e_ = strings.MyFind((x) => x[x.Length - 1] == 'e');

            //Console.WriteLine("\n\n======= stringsEndtWith_e =======");
            //foreach (var item in stringsEndtWith_e_)
            //{
            //    Console.Write($"{item} ");//mane
            //}  

            #endregion

            #endregion

            #region 02 - EventTask [Employee - Department - Club] - Remove emp When AbsentsDays > 3

            //Employee e1 = new Employee() { Id = 1, Name = "Eslam", Salary = 5000 };
            //Employee e2 = new Employee() { Id = 2, Name = "Ahmed", Salary = 4000 };
            //Employee e3 = new Employee() { Id = 3, Name = "Khalid", Salary = 8000 };
            //Employee e4 = new Employee() { Id = 4, Name = "Alyaa", Salary = 9000 };
            //Employee e5 = new Employee() { Id = 5, Name = "Sara", Salary = 10000 };

            //Dept d1 = new Dept() { Id = 1, Name = "HR" };
            //Club c1 = new Club() { Id = 10, Name = "Al-Ahly" };

            //d1.Add(e1);
            //d1.Add(e2);
            //d1.Add(e3);

            //c1.Add(e1);
            //c1.Add(e2);
            //c1.Add(e3);

            //Console.WriteLine(d1);//1 - HR - 3
            //Console.WriteLine(c1);//10 - Al-Ahly - 3

            //Console.WriteLine("\nAfter Increase Absents Days Of e1:");

            ////Test When Increase AbsentDays of e1 =>
            //e1.IncreaseAbsentsDays();//1
            //e1.IncreaseAbsentsDays();//2
            //e1.IncreaseAbsentsDays();//3
            //e1.IncreaseAbsentsDays();//4

            //Console.WriteLine(d1);//1 - HR - 2
            //Console.WriteLine(c1);//10 - Al-Ahly - 2 

            #endregion

        }
    }
}
