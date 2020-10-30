using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Red_Car
{
    class Van : Car
    {
        public Van(int direc,int id)
        {
            set_dirc(direc);
            set_length(3);
            ID = id;
            Color = 2;
        }
    }
}
