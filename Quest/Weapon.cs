using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    abstract class Weapon : Mover
    {
        protected Game game;
        private bool pickedUp;
        public bool PickedUp
        {
            get { return pickedUp; }
        }

        public Weapon(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            // This method is intended to check for enemies in the specified direction and radius,
            // ------------------------------------------------------------------------------------

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy.NearBy(game.PlayerLocation, radius))
                {
                    enemy.Hit(damage, random);
                    return true;
                }
            }

            return false;
        }
    }
}
