using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        public override void Bekle()
        {
            throw new NotImplementedException();
        }

        public override void HaraketEt()
        {
            Random r = new Random();
            int rand = r.Next(1, 8);
            if (rand == 1)
            {
                ykoordinati += 1;
            }
            else if (rand == 2)
            {
                ykoordinati -= 1;
            }
            else if (rand == 3)
            {
                xkoordinati += 1;
            }
            else if(rand == 4)
            {
                xkoordinati -= 1;
            }
            else if(rand == 5)
            {
                xkoordinati += 1;
                ykoordinati += 1;
            }
            else if(rand == 6)
            {
                xkoordinati += 1;
                ykoordinati -= 1;
            }
            else if(rand == 7)
            {
                xkoordinati -= 1;
                ykoordinati += 1;
            }
            else
            {
                xkoordinati -= 1;
                ykoordinati -= 1;
            }
        }
        public override void AtesEt()
        {
            Random r = new Random();
            int rand = r.Next(1, 3);
            if (rand == 1)
            {
                hasar = 15;
            }
            else if (rand == 2)
            {
                hasar = 25;
            }
            else
            {
                hasar = 40;
            }
        }
}
