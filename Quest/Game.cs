using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using Quest.Enemies;
using Quest.Weapons;
using Quest.Potions;

namespace Quest
{
    class Game
    {
        public List<Enemy> Enemies;
        public List<Weapon> WeaponInRoom;

        private Player player;
        public Point PlayerLocation { get {  return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<Weapon> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, 
                new Point(boundaries.Right - 20, (boundaries.Top + boundaries.Bottom) / 2 + 9));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public bool IsHaveEquipedWeapon()
        {
            return player.IsEquipedWeapon();
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            foreach (Weapon weapon in player.Weapons)
            {
                if (weapon.Name == weaponName)
                {
                    return true;
                }
            }
            return false;
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            int xSteps = boundaries.Width / 10;
            int ySteps = boundaries.Height / 10;

            int randomX = random.Next(xSteps);
            int randomY = random.Next(ySteps);

            return new Point(
                boundaries.Left + randomX * 10,
                boundaries.Top + randomY * 10
            );
        }


        public void NewLevel(Random random)
        {
            level++;
            Enemies = new List<Enemy>();
            WeaponInRoom = new List<Weapon>();
            switch (level)
            {
                case 1:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom.Add(new Sword(this, GetRandomLocation(random)));
                    break;
                case 2:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom.Add(new BluePotion(this, GetRandomLocation(random)));
                    break;
                case 3:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom.Add(new Bow(this, GetRandomLocation(random)));
                    break;
                case 4:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom.Add(new Bow(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("BluePotion"))
                        WeaponInRoom.Add(new BluePotion(this, GetRandomLocation(random)));
                    break;
                case 5:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom.Add(new RedPotion(this, GetRandomLocation(random)));
                    break;
                case 6:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom.Add(new Mace(this, GetRandomLocation(random)));
                    break;
                case 7:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Mace"))
                        WeaponInRoom.Add(new Mace(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("RedPotion"))
                        WeaponInRoom.Add(new RedPotion(this, GetRandomLocation(random)));
                    break;
                case 8:
                    MessageBox.Show("Congratulations! You have completed the game!");
                    break;
                default:
                    break;
            }
        }
    }
}
