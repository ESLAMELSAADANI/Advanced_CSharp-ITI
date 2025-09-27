using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class PositionChangedEventArgs
    {
        public int DeltaX { get; set; }
        public int DeltaY { get; set; }

        public override string ToString()
        {
            return $"({DeltaX} , {DeltaY})";
        }
    }

    internal class Ball
    {
        Point position;
        public event EventHandler<PositionChangedEventArgs> OnPositionChanged;//Can refer to any function take one parameter of type object and another of type PositionChangedEventArgs[Any Extra Data] (Object o, PositionChangedEventArgs e)

        internal Point Position { get => position; }

        public void SetPosition(int x, int y)
        {
            PositionChangedEventArgs e = new PositionChangedEventArgs() { DeltaX = position.X - x, DeltaY = position.Y - y };
            position.X = x;
            position.Y = y;
            OnPositionChanged.Invoke(this, e);
        }

        public override string ToString()
        {
            return $"Ball Position - {position}";
        }
    }
}
