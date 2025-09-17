using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.SeriesTask
{
    internal class OddSeries:ISeries
    {
        int count = 1;

        public int GetCount()
        {
            int temp = count;
            count += 2;
            return temp;
        }
    }
}
