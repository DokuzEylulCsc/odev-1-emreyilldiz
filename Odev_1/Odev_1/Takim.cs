using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7];
        
        public Asker[] Birlik { get { return birlik; } set { birlik = value; } }
        public Takim()
        {
            for (int i = 0; i < 5; i++)
            {
                birlik[i] = new Er();
            }
            birlik[5] = new Tegmen();
            birlik[6] = new Yuzbasi();

        }
        public bool takimhayati = true;
        // ..... //
    }
}
