using Quest.Potions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class Player : Mover
    {
        private Weapon? equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } set { hitPoints = value; } }

        private List<Weapon> inventory = new List<Weapon>();
        public List<Weapon> Weapons
        {
            get
            {
                return inventory;
            }
            set
            {
                inventory = value;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            hitPoints = 100;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                    return;
                }
            }
        }

        public bool IsEquipedWeapon()
        {
            return equippedWeapon != null;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            foreach (Weapon weaponInRoom in game.WeaponInRoom)
            {
                if (NearBy(weaponInRoom.Location, 15))
                {
                    inventory.Add(weaponInRoom);
                    game.WeaponInRoom.RemoveAll(w => w == weaponInRoom);
                    break;
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null) return;
            equippedWeapon.Attack(direction, random);
            if (equippedWeapon is BluePotion || equippedWeapon is RedPotion)
            {
                equippedWeapon = null;
            }
        }
    }
}
