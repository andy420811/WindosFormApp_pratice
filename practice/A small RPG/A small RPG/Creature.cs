using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_small_RPG
{
    class Creature
    {
        private int HP;
        private int MP;
        private int ATK;
        private bool state; // determine the charactor is out of MP or not
        private bool init = false;
        public int get_HP { get { return HP; } }
        public int get_MP { get { return MP; } }
        public Creature()
        {
            this.HP = 10;
            this.MP = 10;
            this.ATK = 10;
            this.state = true;
        }
        /// <summary>
        /// If the init is set return true else false
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="mp"></param>
        /// <param name="atk"></param>
        /// <returns></returns>
        public bool Set_Init(int hp,int mp, int atk)
        {
            if (init == false) {
                HP = hp;
                MP = mp;
                ATK = atk;
                init = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// return true if alive
        /// </summary>
        /// <returns></returns>
        
        public Creature(int hp,int mp, int atk)
        {
            this.HP = hp;
            this.MP = mp;
            this.ATK = atk;
            this.state = true;
        }
        public void Enhence(int atk)
        {
            ATK += atk;
        }
        /// <summary>
        /// return [HP(now),MP(now),HP(up),MP(up)]
        /// </summary>
        /// <param name="HP"></param>
        /// <param name="MP"></param>
        /// <returns></returns>
        public int[] Recover(int HP,int MP)
        {
            int[] a = new int[4];
                a[2] = HP;
                a[3] = MP;
                a[0] = (this.HP += HP);
                a[1] = (this.MP += MP);
                return a;
        }
        /// <summary>
        /// return Atk value
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Atk(Creature Atked)
        {
                Atked.HP -= this.ATK;
                return this.ATK;
        }
        public bool Check_State{
            get { return state; }
        }
        public int get_ATK
        {
            get { return ATK; }
        }
        public void Mp_cost()
        {
            if(MP < 5)
            {
                state = false;
            }
            else
            {
                MP -= 5;
            }
        }
    }
}
