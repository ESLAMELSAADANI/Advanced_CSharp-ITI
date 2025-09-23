using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04._02___Event_Task
{
    internal class Club : IEquatable<Club>
    {

        #region Properties & Fields

        public int Id { get; set; }
        public string Name { get; set; }
        List<Employee> emps = new List<Employee>();

        #endregion

        #region Methods
        
        public void Add(Employee e)
        {
            emps.Add(e);
            e.AbsentsMoreThan3 += Remove;
        }

        public void Remove(Employee e)
        {
            emps.Remove(e);
        }

        public bool Equals(Club? other)
        {
            if (other is not null)
                return Id == other.Id && Name == other.Name && emps.Count == other.emps.Count;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {emps.Count}";
        } 

        #endregion

    }
}
