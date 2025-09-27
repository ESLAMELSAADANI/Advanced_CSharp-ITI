using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Referee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void MoveReferee(Object sender /*ball*/, PositionChangedEventArgs e)
        {
            Ball ball = sender as Ball;//ast sender of type Object as of type Ball
            Console.WriteLine($"From Referee ({this}) :: Ball Position Changed : ({ball}) :: Delta X&Y => {e}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
