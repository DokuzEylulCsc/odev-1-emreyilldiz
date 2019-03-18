using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker 
    {
        public override void Bekle()
        {
            throw new NotImplementedException();
        }

        public override void HaraketEt()
        {
            Random r = new Random();
           int rand = r.Next(1, 2);
            if(rand == 1)
            {
                ykoordinati += 1;
            }
            else
            {
                ykoordinati -= 1;
            }

        }
        public override void AtesEt()
        {
            Random r = new Random();
            int rand = r.Next(1, 3);
            hasar = rand * 5;
        }

    }
}
