using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03._03___HashSet_Task
{
    internal class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public bool Equals(Employee? other)
        {
            if (other is null)
                return false;
            return Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Employee);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"Id = {Id} - Name = {Name} - Salary = {Salary}";
        }
    }
}
