using Day03._01_MyList_Task;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> l1 = new MyList<int>(5);

            Console.WriteLine($"Capacity: {l1.Capacity}");//5
            Console.WriteLine($"Length: {l1.length}");//0
            Console.WriteLine("=============");

            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);

            l1.Print();
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//5
            Console.WriteLine($"Length: {l1.length}");//5
            Console.WriteLine("=============");

            l1.Add(6);

            l1.Print();
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//10
            Console.WriteLine($"Length: {l1.length}");//6
            Console.WriteLine("=============");

            l1.Add(7);
            l1.Add(8);
            l1.Add(9);
            l1.Add(10);

            l1.Print();
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//10
            Console.WriteLine($"Length: {l1.length}");//10
            Console.WriteLine("=============");


            l1.Remove(8);
            l1.Remove(4);
            l1.Remove(25);//Not Found This Value -> 25!
            l1.Print();//1 2 3 5 6 7 9 10
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//Capacity: 8
            Console.WriteLine($"Length: {l1.length}");//Length: 8
            Console.WriteLine("=============");

            l1.Add(7);
            l1.Add(8);
            l1.Print();//1 2 3 5 6 7 9 10 7 8 0 0 0 0 0 0
            Console.WriteLine($"\nCapacity: {l1.Capacity}");//Capacity: 16
            Console.WriteLine($"Length: {l1.length}");//Length: 10
            Console.WriteLine("=============");

            Console.WriteLine(l1[0]);//1
            Console.WriteLine(l1[9]);//8
            //Console.WriteLine(l1[11]);//Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
            Console.WriteLine("=============");

            l1[0] = 20;
            l1[9] = 40;
            //l1[15] = 25;//Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.

            l1.Print();//20 2 3 5 6 7 9 10 7 40 0 0 0 0 0 0

        }
    }
}
