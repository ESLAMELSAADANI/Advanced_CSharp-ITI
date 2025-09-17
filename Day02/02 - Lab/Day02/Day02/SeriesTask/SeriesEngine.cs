using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.SeriesTask
{
    internal class SeriesEngine
    {
        public static void printSeries(ISeries s)
        {
            Console.WriteLine(s.GetCount());          
        }
    }
}
