using Day02.SeriesTask;
using Day02.EmpArraySortTask;
using Day02.Swap__GenericTask;
namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task01 - Serieses

            #region 01 - Before Use Interface ISeries

            //OddSeries odd1 = new OddSeries();
            //odd1.GetCount();//1
            //odd1.GetCount();//3
            //odd1.GetCount();//5
            //odd1.GetCount();//7

            //Console.WriteLine("===========================");

            //EvenSeries even1 = new EvenSeries();
            //even1.GetCount();//0
            //even1.GetCount();//2
            //even1.GetCount();//4
            //even1.GetCount();//8

            //Console.WriteLine("===========================");

            //FibSeries fib1 = new FibSeries();
            //fib1.GetCount();//0
            //fib1.GetCount();//1
            //fib1.GetCount();//1
            //fib1.GetCount();//2
            //fib1.GetCount();//3
            //fib1.GetCount();//5
            //fib1.GetCount();//8 

            #endregion

            #region 02 - After Use Interface ISeries

            //OddSeries odd1 = new OddSeries();
            //EvenSeries even1 = new EvenSeries();
            //FibSeries fib1 = new FibSeries();

            //SeriesEngine.printSeries(odd1);
            //SeriesEngine.printSeries(odd1);
            //SeriesEngine.printSeries(odd1);
            //SeriesEngine.printSeries(odd1);

            //Console.WriteLine("===========================");

            //SeriesEngine.printSeries(even1);
            //SeriesEngine.printSeries(even1);
            //SeriesEngine.printSeries(even1);
            //SeriesEngine.printSeries(even1);

            //Console.WriteLine("===========================");

            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);
            //SeriesEngine.printSeries(fib1);

            #endregion

            #endregion

            #region Task02 - SortEmployeesArray & Use IComparable

            //Emp[] emps = [
            //    new Emp(){Id=5,Name="Eslam"},
            //    new Emp(){Id=8,Name="Khalid"},
            //    new Emp(){Id=10,Name="Abdelrahman"},
            //    new Emp(){Id=4,Name="Sara"},
            //    new Emp(){Id=2,Name="Nourhan"},
            //    new Emp(){Id=1,Name="Ziad"},
            //    new Emp(){Id=9,Name="Yasmeen"},
            //    ];

            //Array.Sort(emps);

            //int counter = 1;
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine($"{counter}- {emp}");
            //    counter++;
            //} 

            #endregion

            #region Task03 - IComparer Provide New Compare

            //Emp[] emps = [
            //    new Emp(){Id=5,Name="Eslam"},
            //    new Emp(){Id=8,Name="Khalid"},
            //    new Emp(){Id=10,Name="Abdelrahman"},
            //    new Emp(){Id=4,Name="Sara"},
            //    new Emp(){Id=2,Name="Nourhan"},
            //    new Emp(){Id=1,Name="Ziad"},
            //    new Emp(){Id=9,Name="Yasmeen"},
            //    ];

            //Array.Sort(emps, new EmpNameComparer());


            //int counter = 1;
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine($"{counter}- {emp}");
            //    counter++;
            //}

            #endregion

            #region Task04 - SWAP<T>() 

            //int x = 5, y = 6;
            //SwapGeneric.Swap(ref x, ref y);
            //Console.WriteLine($"x = {x} - y = {y}");

            //Console.WriteLine("==========================");
            //float a = 10.5f, b = 11.25f;
            //SwapGeneric.Swap(ref a, ref b);
            //Console.WriteLine($"a = {a} - b = {b}");

            //Console.WriteLine("==========================");
            //Emp e1 = new Emp() { Id = 5, Name = "Eslam" };
            //Emp e2 = new Emp() { Id = 6, Name = "Ahmed" };
            //SwapGeneric.Swap(ref e1, ref e2);
            //Console.WriteLine($"e1 = {e1} - e2 = {e2}");

            #endregion

        }
    }
}
