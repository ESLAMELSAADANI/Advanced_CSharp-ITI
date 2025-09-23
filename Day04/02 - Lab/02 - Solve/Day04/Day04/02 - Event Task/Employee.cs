using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04._02___Event_Task
{
    internal class Employee : IEquatable<Employee>
    {
        //Publisher => Because it's the one that event occur on it [When AbsentsDays be more then 3 do Remove Student]
        
        #region Properties & Fields
        
        int absentDays = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public event Action<Employee> AbsentsMoreThan3;
        public int GetAbsentsDays() => absentDays;

        #endregion

        #region Methods

        public void IncreaseAbsentsDays()
        {
            absentDays++;
            if (absentDays > 3)
            {
                AbsentsMoreThan3?.Invoke(this);
            }
        }

        public bool Equals(Employee? other)
        {
            if (other is not null)
                return Id == other.Id;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Salary} - {absentDays}";
        } 

        #endregion

    }
}
