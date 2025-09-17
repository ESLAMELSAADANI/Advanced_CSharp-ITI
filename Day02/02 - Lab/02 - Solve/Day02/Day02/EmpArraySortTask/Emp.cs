using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.EmpArraySortTask
{
    internal class Emp : IComparable
    {

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Methods

        public int CompareTo(object? obj)
        {
            Emp? emp = obj as Emp;
            if (emp is null)
                return 1;
            else
                return Id.CompareTo(emp.Id);
        }
        //public int CompareTo(object? obj)
        //{
        //    Emp? emp = obj as Emp;
        //    if (emp is null)
        //        return 1;
        //    else
        //    {
        //        if (Name is null)
        //            return -1;
        //        else
        //            return Name.CompareTo(emp.Name);
        //    }
        //}

        public override string ToString()
        {
            return $"Id:{Id} - Name:{Name}";
        }

        #endregion

    }
}
