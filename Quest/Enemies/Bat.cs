using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Enemies
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            int forward = random.Next(0, 2);
            Direction direction;
            if (forward == 1)
            {
                direction = FindPlayerDirection(game.PlayerLocation);
            } else
            {
                direction = (Direction)random.Next(0, 4);
            }
            Location = base.Move(direction, game.Boundaries);

            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
