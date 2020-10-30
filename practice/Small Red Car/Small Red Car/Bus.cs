using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Red_Car
{
    class Bus : Car
    {
        public Bus(int direc,int id )
        {
            set_dirc(direc);
            set_length(4);
            ID = id;
            Color = 0;
        }
    }
}
