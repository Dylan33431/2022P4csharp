using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal enum Element
    {
        Fire,
        water,
        grass,
        electro
    }
    internal class ConsoleMon
    {
        string name = "Xuritree";
        int Health = 70;
        int Energy = 60;
        int damage;
        Element weakness = Element.water;

        public void TakeDamage(int Damage)
        {
            Health = -Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = -energy;
        }

        List<Skill> skills = new List<Skill>();

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.name = copyFrom.name;
            this.Health = copyFrom.Health;
            this.Energy = copyFrom.Energy;

            this.damage = copyFrom.damage;

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.skills.Add(copy);
            }
        }
    }
}