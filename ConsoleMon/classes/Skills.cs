using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        string name = "Zap Cannon";
        float damage = 120;
        float energyCost = 60;

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(120);
            caster.DepleteEnergy(60);
        }

    }

}
