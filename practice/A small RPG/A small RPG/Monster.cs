using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_small_RPG
{
    class Monster :  Creature
    {

        Skill skill = new Skill();
        Random rd = new Random();
        private bool Imple = false;

        public bool Implement_skl { get { return Imple; } }

        public Monster(int HP, int MP, int atk) : base(HP, MP, atk) { }
        public Monster()
        {
            Set_Init(70, 10, 20);
        }


        public bool Skill(Creature hero)
        {
            return skill.car(3, this, hero);
        }
        /// <summary>
        /// return 0 atk; 1 skill success; 2 skill fail 
        /// </summary>
        /// <param name="hero"></param>
        /// <returns></returns>
        public int Attack(Creature hero)
        {
            if (rd.Next(1, 6) == 1)
            {
                Imple = true;
                return this.Skill(hero) ? 1 : 2;
            }
            else
            {
                Imple = false;
                Atk(hero);
                return 0;
            }
        }
    }
}
