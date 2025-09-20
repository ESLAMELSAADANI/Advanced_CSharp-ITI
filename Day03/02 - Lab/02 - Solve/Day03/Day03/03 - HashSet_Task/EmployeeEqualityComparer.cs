using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03._03___HashSet_Task
{
    internal class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x is null || y is null)
                return false;
            return x.Name.ToLower() == y.Name.ToLower();
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.ToLower().GetHashCode();
        }
    }
}
