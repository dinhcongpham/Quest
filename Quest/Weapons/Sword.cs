using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Weapons
{
    class Sword : Weapon
    {
        private string name = "Sword";
        public Sword(Game game, Point location) : base(game, location) { }
        public override string Name
        {
            get { return name; }
        }

        public override void Attack(Direction direction, Random random)
        {
            bool canAttackOriginalDirection = DamageEnemy(direction, 40, 3, random);
            if (canAttackOriginalDirection) return;

            Direction clockWiseDirection = GetDirectionByStep(direction, 1);
            bool canAttackClockwiseDirection = DamageEnemy(clockWiseDirection, 40, 3, random);
            if (canAttackClockwiseDirection) return;

            Direction counterClockwiseDirection = GetDirectionByStep(direction, -1);
            bool canAttackCounterClockwiseDirection = DamageEnemy(counterClockwiseDirection, 40, 3, random);
            if (canAttackCounterClockwiseDirection) return;
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
