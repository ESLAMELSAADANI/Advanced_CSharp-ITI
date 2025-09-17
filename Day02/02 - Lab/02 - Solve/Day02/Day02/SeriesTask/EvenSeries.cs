using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.SeriesTask
{
    internal class EvenSeries : ISeries
    {
        int count = 0;

        public int  GetCount()
        {
            int temp = count;
            count += 2;
            return temp;
        }
    }
}
