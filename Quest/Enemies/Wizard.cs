using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Enemies
{
    class Wizard : Enemy
    {
        public Wizard(Game game, Point location) : base(game, location, 15) { }
        public override void Move(Random random)
        {
            int forward = random.Next(0, 2);
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            Location = base.Move(direction, game.Boundaries);
            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
