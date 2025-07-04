using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location {
            get { return location; }
            set { location = value; }
        }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool NearBy(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                Math.Abs(location.Y - locationToCheck.Y) < distance)
                return true;

            return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocaltion = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocaltion.Y - MoveInterval >= boundaries.Top)
                        newLocaltion.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocaltion.Y + MoveInterval <= boundaries.Bottom)
                        newLocaltion.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocaltion.X - MoveInterval >= boundaries.Left)
                        newLocaltion.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocaltion.X + MoveInterval <= boundaries.Right)
                        newLocaltion.X += MoveInterval;
                    break;
                default:
                    break;
            }

            return newLocaltion;
        }
    }
}
