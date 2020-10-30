using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Small_Red_Car
{
    class Car
    {
        private int Length;
        private int Direc;
        public int ID;
        public int Color;
        public int get_Dirc { get { return Direc; } }
        private Point Init_Pos = new Point();
        protected int Block_sz { get { return Block_sz; } set { Block_sz = 5; } }
        public int get_Length { get { return Length; } }
        public Car() { }
        public void set_pos(int x,int y)
        {
            Init_Pos = new Point(x, y);
        }
        public Point get_pos
        {
            get { return Init_Pos; }
        }
        protected void set_length(int length)
        {
            Length = length;
        }
        protected void set_dirc(int dirc)
        {
            Direc = dirc;
        }
        /// <summary>
        /// direction 0 for hz ,1 for vt
        /// </summary>
        /// <param name="length"></param>
        /// <param name="direc"></param>
        public Car(int length,int direc)
        {
            Length = length;
            Direc = direc;
        }

        /// <summary>
        /// right 0  left 1  up 2  down 3 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public void move(int direc,int shift)
        {
            if(Direc == 0)
            {
                if (direc == 0) Init_Pos.X += shift;
                if (direc == 1) Init_Pos.X -= shift;
            }
            else
            {
                if (direc == 2) Init_Pos.Y += shift;
                if (direc == 3) Init_Pos.Y -= shift;
            }
        }
        /// <summary>
        /// right 0  left 1  up 2  down 3 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool move(int direc)
        {
            if (Direc == 1)
            {
                if (direc == 0) { Init_Pos.X += 1; return true; }
                if (direc == 1) { Init_Pos.X -= 1; return true; }
                return false;
            }
            else
            {
                if (direc == 2) { Init_Pos.Y -= 1; return true; }
                if (direc == 3) { Init_Pos.Y += 1; return true; }
                return false;
            }
        }
    }
}
