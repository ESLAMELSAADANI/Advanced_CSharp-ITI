using Day03._01_MyList_Task;
//using Day03._02___BuiltInList_Task;
using Day03._02___BuiltInList_Task;
using Day03._03___HashSet_Task;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace Day03
{
    internal class Program
    {
        public delegate t3 MyDel<in t1, in t2, out t3>(t1 x, t2 y);

        public static int Add(int x, int y)
        {
            Console.Write("Add Function! ");
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            Console.Write("Sub Function! ");
            return x - y;
        }
        public static int Mul(int x, int y)
        {
            Console.Write("Mul Function! ");
            return x * y;
        }
        public static int Mod(int x, int y)
        {
            Console.Write("Mod Function! ");
            return x % y;
        }
        static void Main(string[] args)
        {

            #region 01 - MyList Task

            MyList<int> l1 = new MyList<int>(5);

            Console.WriteLine($"Capacity: {l1.Capacity}");//5
            Console.WriteLine($"Length: {l1.Length}");//0
            Console.WriteLine("=============");

            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);

            l1.Print();//1 2 3 4 5
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//5
            Console.WriteLine($"Length: {l1.Length}");//5
            Console.WriteLine("=============");

            l1.Add(6);

            l1.Print();//1 2 3 4 5 6 0 0 0 0
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//10
            Console.WriteLine($"Length: {l1.Length}");//6
            Console.WriteLine("=============");

            l1.Add(7);
            l1.Add(8);
            l1.Add(9);
            l1.Add(10);

            l1.Print();//1 2 3 4 5 6 7 8 9 10
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//10
            Console.WriteLine($"Length: {l1.Length}");//10
            Console.WriteLine("=============");


            l1.Remove(8);
            l1.Remove(4);
            l1.Remove(25);//Not Found This Value -> 25!
            l1.Print();//1 2 3 5 6 7 9 10
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//Capacity: 8
            Console.WriteLine($"Length: {l1.Length}");//Length: 8
            Console.WriteLine("=============");

            l1.Add(7);
            l1.Add(8);
            l1.Print();//1 2 3 5 6 7 9 10 7 8 0 0 0 0 0 0
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//Capacity: 16
            Console.WriteLine($"Length: {l1.Length}");//Length: 10
            Console.WriteLine("=============");

            Console.WriteLine(l1[0]);//1
            Console.WriteLine(l1[9]);//8
            //Console.WriteLine(l1[11]);//Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
            Console.WriteLine("=============");

            l1[0] = 20;
            l1[9] = 40;
            //l1[15] = 25;//Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.

            l1.Print();//20 2 3 5 6 7 9 10 7 40 0 0 0 0 0 0 

            #endregion

            #region 02 - ListBuilt In Task

            //MyListBuiltIn<int> myListInt = new MyListBuiltIn<int>();
            //myListInt.Add(1);
            //myListInt.Add(2);
            //myListInt.Add(3);
            //myListInt.Add(4);
            //myListInt.Add(5);

            //myListInt.ReadFile();

            //MyListBuiltIn<string> myListString = new MyListBuiltIn<string>();
            //myListString.Add("Eslam");
            //myListString.Add("Ashraf");
            //myListString.Add("Abdelazem");
            //myListString.Add("Mohamed");
            //myListString.Add("Khalaf");

            //myListString.ReadFile(); 

            #endregion

            #region 03 - HashSet Task

            #region 01 - With Premetive Types

            //HashSet<int> ints = new HashSet<int>() { 1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 9, 10, 10 };

            //foreach (var num in ints)
            //{
            //    Console.Write($"{num} ");//1 2 3 4 5 6 7 8 9 10
            //} 

            #endregion

            //Console.WriteLine();

            #region 02 - With Non-Premitive Types

            #region 02.1 - Compare Based On ID Value.

            //HashSet<Employee> employees01 = new HashSet<Employee>()
            //{
            //    new Employee(){Id = 1,Name = "Eslam",Salary = 10_000},
            //    new Employee(){Id = 1,Name = "Eslam",Salary = 10_000},
            //    new Employee(){Id = 2,Name = "ashraf",Salary = 10_000},
            //    new Employee(){Id = 2,Name = "Ashraf",Salary = 20_000},
            //    new Employee(){Id = 3,Name = "Ahmed",Salary = 20_000},
            //};

            //foreach (var emp in employees01)
            //{
            //    Console.WriteLine(emp);
            //}
            //// Id = 1 - Name = Eslam - Salary = 10000
            //// Id = 2 - Name = ashraf - Salary = 10000
            //// Id = 3 - Name = Ahmed - Salary = 20000 

            #endregion

            //Console.WriteLine("=========================================");

            #region 02.2 - Compare Based On Name Value.

            //HashSet<Employee> employees02 = new HashSet<Employee>(new EmployeeEqualityComparer())
            //{
            //    new Employee(){Id = 1,Name = "Eslam",Salary = 10_000},
            //    new Employee(){Id = 1,Name = "Khalid",Salary = 10_000},
            //    new Employee(){Id = 2,Name = "ashraf",Salary = 10_000},
            //    new Employee(){Id = 3,Name = "Ashraf",Salary = 20_000},
            //    new Employee(){Id = 4,Name = "Ahmed",Salary = 20_000},
            //    new Employee(){Id = 5,Name = "Ahmed",Salary = 20_000},
            //};

            //foreach (var emp in employees02)
            //{
            //    Console.WriteLine(emp);
            //}
            //// Id = 1 - Name = Eslam - Salary = 10000
            //// Id = 1 - Name = Khalid - Salary = 10000s
            //// Id = 2 - Name = ashraf - Salary = 10000
            //// Id = 4 - Name = Ahmed - Salary = 20000  

            #endregion

            #endregion

            #endregion

            #region 04 - Delegate Task

            #region 01 - User Defined

            //MyDel<int, int, int> myDel1 = Add;
            //Console.WriteLine(myDel1.Invoke(5, 6));//Add Function! 11

            //myDel1 += Sub;
            //Console.WriteLine(myDel1.Invoke(5, 6));//Add Function! Sub Function! -1

            //myDel1 += Mul;
            //myDel1 += Mod;
            //Console.WriteLine(myDel1.Invoke(6, 4));//Add Function! Sub Function! Mul Function! Mod Function! Add Function! 10

            //myDel1 -= Mod;
            //Console.WriteLine(myDel1?.Invoke(6, 4));//Add Function! Sub Function! Mul Function! 24 

            #endregion

            #region 02 - Built-In

            //Func<int, int, int> func = new Func<int, int, int>(Add);
            //Console.WriteLine(func.Invoke(10, 20));//Add Function! 30

            //func += Sub;
            //func += Mul;
            //func += Mod;

            //Console.WriteLine(func.Invoke(10, 20));// Add Function!Sub Function! Mul Function!Mod Function! 10 

            #endregion

            #endregion

            #region 05 - Find(Predicate p) Task

            //MyList<int> myList = new MyList<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);
            //myList.Add(6);
            //myList.Add(7);
            //myList.Add(8);
            //myList.Add(9);
            //myList.Add(10);

            //MyList<int> newList = myList.Find((x) => x % 2 == 0);

            //newList.Print();//2 4 6 8 10 

            #endregion

        }
    }
}
