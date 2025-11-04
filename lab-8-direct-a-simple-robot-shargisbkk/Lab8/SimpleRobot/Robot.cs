using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    

    internal class Robot
    {
        public enum Direction {North, East, South, West}
        private Direction currentDirection;
        public Point position { get; private set; }

        // holds the event handler for when the robot goes out of bounds, nullable because it may not be used
        public event EventHandler? TooFar;

        public Robot()
        {
            position = new Point(0, 0);
            currentDirection = Direction.North;
        }
        public Direction CurrentDirection
        {
            get => currentDirection;
            set => currentDirection = value;
        }
        public void MoveRobot(int steps)
        {
            Point newPosition = position;

            switch (currentDirection)
            {
                case Direction.North:
                    newPosition.Y += steps;
                    break;
                case Direction.East:
                    newPosition.X += steps;
                    break;
                case Direction.South:
                    newPosition.Y -= steps;
                    break;
                case Direction.West:
                    newPosition.X -= steps;
                    break;
            }

            if (Math.Abs(newPosition.X) > 100 || Math.Abs(newPosition.Y) > 100)
            {
                // manually trigger the TooFar event if the robot goes out of bounds, nullable because it may not be used
                TooFar?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                position = newPosition;
            }
        }
    }


}
