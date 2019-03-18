using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public abstract class Asker
    {

        public Bolge Koordinat;
        public int saglik = 100;
        public bool canlilik=true;
        public int xkoordinati;
        public int ykoordinati;
        public int hasar;
        // ..... //

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void AtesEt();

        // ..... //

    }
}
