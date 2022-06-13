using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    internal class ConsoleMon
    {
        string name = "Xuritree";
        int Health = 70;
        int Energy = 60;


        public void TakeDamage(int Damage)
        {
            Health = -Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = -energy;
        }

        List<Skill> skills = new List<Skill>();
    }
}