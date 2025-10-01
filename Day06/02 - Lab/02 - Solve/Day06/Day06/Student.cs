using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Student : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        StreamWriter sw;
        public Student(int _id, string _name, int _age)
        {
            Id = _id;
            Name = _name;
            Age = _age;

            sw = new StreamWriter("myFile.txt", true);//bin/debug/myFile.txt
            sw.WriteLine($"{_id} - {_name} - {_age}");

        }


        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }

        //~Student() { }
        public void Dispose()
        {
            sw.Dispose();
            Console.WriteLine("Finalize The Object!");
        }
    }
}
