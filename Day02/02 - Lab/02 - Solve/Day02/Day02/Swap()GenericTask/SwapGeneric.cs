using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.Swap__GenericTask
{
    internal class SwapGeneric
    {
        public static void Swap<t>(ref t x,ref t y) //where t : class /*struct*/, IComparable, new()
        {
            t temp = x;
            x = y;
            y = temp;

            //if(x == y)// class 
            //{
            //    Console.WriteLine(x==y);
            //}

            //x = new t();//class,new() || struct, new()

            //if (x.CompareTo(y) == 1)//class,IComparable
            //{
            //    Console.WriteLine("x>y");
            //}

        }
    }
}
