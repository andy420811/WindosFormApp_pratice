using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Red_Car
{
    class RedCar : Car
    {
        public RedCar(int direc,int id)
        {
            set_dirc(direc);
            set_length(2);
            ID = id;
            Color = 1;
        }
    }
}
