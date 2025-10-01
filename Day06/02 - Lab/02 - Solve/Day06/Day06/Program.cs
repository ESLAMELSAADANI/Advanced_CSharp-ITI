using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task01 - Try&Catch Example.

            //try
            //{
            //    int[] arr = [10, 2, 30, 40];
            //    Console.WriteLine(arr[5]);

            //}
            //catch (Exception e)
            //{
            //    throw new Exception("Custom Message=> ", e);
            //}

            #endregion

            #region Task02 - MyList With Some Exceptions

            //MyList<string> myList = new MyList<string>();
            //myList.Add("Eslam");
            //myList.Add("Ashraf");
            //myList.Add("Abdelazem");
            //myList.Add("Mohamed");

            //Console.WriteLine(myList[3]);//Mohamed

            ////Test read&set value of invalid index => Exception out of range

            //Console.WriteLine(myList[4]);//There is no Data!Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
            //myList[4] = "zizooo";//Can't Set New Data - Just Update! Unhandled exception. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.

            #endregion

            #region Task03 - Class Student Implement IDisposable to control the released of an object => no when released and control it.

            //using Student s1 = new Student(1, "Eslam", 23);
            //Console.WriteLine(s1);//1 - Eslam - 23
            ////                      Finalize The Object!
            ////Call Dispose Direct after this line finish
            ////Inside Dispose() we close the resource[File] and cw(Finalize the object).
            //Console.WriteLine(GC.GetGeneration(s1));//0
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Console.WriteLine(GC.GetGeneration(s1));//0

            #endregion

        }
    }
}
