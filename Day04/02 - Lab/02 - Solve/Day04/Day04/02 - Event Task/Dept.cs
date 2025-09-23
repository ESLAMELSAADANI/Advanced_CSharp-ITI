using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04._02___Event_Task
{
    internal class Dept : IEquatable<Dept> //Subscriber => The one that make the Registration of function Address to delegate.
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
            e.AbsentsMoreThan3 += Remove;//Registration => register the function that will executed when delegate/event Fired to the delegate.
        }

        public void Remove(Employee e)//Event Handler => Function that will execute when event [AbsentsMoreThan3] Fired[Invoked].
        {
            emps.Remove(e);
        }

        public bool Equals(Dept? other)
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
