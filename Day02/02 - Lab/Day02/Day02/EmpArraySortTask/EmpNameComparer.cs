using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.EmpArraySortTask
{
    internal class EmpNameComparer : IComparer<Emp>
    {
        public int Compare(Emp? x, Emp? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
