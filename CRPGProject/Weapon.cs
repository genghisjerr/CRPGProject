using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGProject
{
    public class Weapon : Items
    {
        public int MaximumDamage;
        public int MinimumDamage;

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage):base(id, name, namePlural)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }
    }
}
