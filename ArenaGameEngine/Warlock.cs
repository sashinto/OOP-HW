using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    // - Has a 30% chance to deal 4 times his Strength in damage, but takes half of his Strength in damage.
    public class Warlock : Hero
    {
        public Warlock(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            if (Random.Shared.Next(0, 100) <= 30)
            {
                baseAttack = Strength * 4;
                TakeDamage(Strength / 2);
            }
            return baseAttack;
        }
    }
}
