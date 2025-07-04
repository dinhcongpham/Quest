using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Enemies
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }
        public override void Move(Random random)
        {
            int forward = random.Next(0, 3);
            if (forward == 0)
            {
                Direction direction = FindPlayerDirection(game.PlayerLocation);
                Location = base.Move(direction, game.Boundaries);
            }

            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
