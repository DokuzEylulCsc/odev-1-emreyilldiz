using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }

        public Ermeydani()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Harita[i, j] = new Bolge(i, j);
                }
            }
        }



    }

}



