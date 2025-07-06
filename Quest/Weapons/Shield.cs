using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Weapons
{
    class Shield : Weapon
    {
        private string name = "Shield";
        public Shield(Game game, Point location) : base(game, location) { }
        public override string Name
        {
            get { return name; }
        }
        public override void Attack(Direction direction, Random random)
        {

        }
    }
}
