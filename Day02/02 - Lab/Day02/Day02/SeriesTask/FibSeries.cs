using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.SeriesTask
{
    internal class FibSeries : ISeries
    {
        int prev = 0;
        int current = 1;

        public int GetCount()
        {
            int temp = prev + current;
            prev = current;
            current = temp;
            return prev;
        }
    }
}
