using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    // - Has a 30% chance to heal himself for half of his Strength.
    public class Druid: Hero
    {
        public Druid(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 30)
            {
                Heal(Strength / 2);
            }
            return baseAttack;
        }

    }
}
