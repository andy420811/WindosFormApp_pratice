using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_small_RPG
{
    class Hero : Creature
    {
        Skill skill = new Skill();
        private bool Imple;
        private int Career;
        private bool shield;
        public bool get_Shield { get { return shield; } set { shield = value; } }
        public bool Implement_skl { get { return Imple; } }
        /// <summary>
        /// 0 warrior   1 tank    2 rider
        /// </summary>
        /// <param name="career"></param>
        public Hero (int career,int HP,int MP,int atk):base(HP,MP,atk) {
            Career = career;
        }
        public Hero() { }
        /// <summary>
        /// 0 warrior   1 tank    2 rider
        /// </summary>
        /// <param name="career"></param>
        public Hero (int career)
        {
            Career = career;
            switch (career)
            {
                case 0:
                    Set_Init(100, 15, 20);
                    break;
                case 1:
                    Set_Init(150, 15, 15);
                    break;
                case 2:
                    Set_Init(80, 20, 25);
                    break;
            }
        }
        public int career {
            get { return Career; }
        }
        /// <summary>
        /// retrun bool skill implement or not
        /// </summary>
        /// <param name="mon"></param>
        /// <returns></returns>
        public bool Skill(Creature mon)
        {
            Imple = skill.car(Career, this, mon);
            if(Imple)
            shield = skill.Shield_state;
            return Imple;
        }
        
        
    }
}
