using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_small_RPG
{
    class Skill
    {
        private bool shield;
        public Skill()
        {
        }
        public bool Shield_state
        {
            get { return shield; }
        }
        /// <summary>
        /// 0 warrior   1 tank    2 rider   3 monster
        /// if
        /// </summary>
        /// <param name="c"></param>
        /// <param name="hero"></param>
        /// <param name="mon"></param>
        public bool car(int c, Creature hero,Creature mon)
        {
            hero.Mp_cost();
            if (hero.Check_State)
            {
                switch (c)
                {
                    case 0:
                        this.warrior(hero, mon);
                        return true;
                    case 1:
                        this.tank(hero, mon);
                        return true;
                    case 2:
                        this.rider(hero, mon);
                        return true;
                    case 3:
                        this.mon(hero, mon);
                        return true;
                    default:
                        return true;
                }
            }
            else { return false; }
        }
        /// <summary>
        /// if skill is applied return true else false
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="mon"></param>
        /// <returns></returns>
        private bool warrior(Creature hero,Creature mon)
        {
            hero.Recover(hero.Atk(mon), 0);
                return true;
        }
        
        /// <summary>
        /// if shield is on return true ,off false
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="mon"></param>
        /// <returns></returns>
        private bool tank(Creature hero, Creature mon)
        {
            shield = true;
            return true;
        }
        private bool rider(Creature hero, Creature mon)
        {
            int hit = 2;
            for(int i = 0; i < hit; i++)
            {
                hero.Atk(mon);
            }
            return true;
        }
        private bool mon(Creature mon, Creature hero)
        {
            mon.Recover(20, 0);
            mon.Enhence(10);
            return true;
        }

    }
}
