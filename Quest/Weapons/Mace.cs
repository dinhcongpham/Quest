using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Weapons
{
    class Mace : Weapon
    {
        private string name = "Mace";
        public Mace(Game game, Point location) : base(game, location) { }
        public override string Name
        {
            get { return name; }
        }
        public override void Attack(Direction direction, Random random)
        {
            bool canAttack = DamageEnemy(direction, 50, 6, random);
            if (!canAttack)
            {
                direction = GetDirectionByStep(direction, 1);
                canAttack = DamageEnemy(direction, 50, 6, random);
            }
            if (!canAttack)
            {
                direction = GetDirectionByStep(direction, 1);
                canAttack = DamageEnemy(direction, 50, 6, random);
            }
            if (!canAttack)
            {
                direction = GetDirectionByStep(direction, 1);
                canAttack = DamageEnemy(direction, 50, 6, random);
            }
        }

        public Direction GetDirectionByStep(Direction direction, int step)
        {
            Array values = Enum.GetValues(typeof(Direction));
            int index = Array.IndexOf(values, direction);
            if (index < 0) throw new ArgumentException("Invalid direction");
            index = (index + step) % values.Length;
            if (index < 0) index += values.Length;
            return (Direction)(values.GetValue(index) ?? throw new InvalidOperationException("Enum value is null"));
        }
    }
}
