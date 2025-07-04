using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Potions
{
    class RedPotion : Weapon, IPotion
    {
        private bool used;
        public bool Used
        {
            get { return used; }
            set { used = value; }
        }
        public RedPotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }
        public override string Name
        {
            get { return "RedPotion"; }
        }
        public override void Attack(Direction direction, Random random)
        {
            Used = true;
            game.IncreasePlayerHealth(10, random);
            PickUpWeapon();
        }
    }
}
