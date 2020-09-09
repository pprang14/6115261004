using System;
using System.Collections.Generic;
using System.Text;

namespace _6115261004
{
    class House
    {
        private int bedRoom;
        private int bathRoom;
        private float area;
        private Decoration decor;
        private Village villages;



        public House(int bedRoom, int bathRoom, float area, Decoration decor, Village villages)
        {
            this.bedRoom = bedRoom;
            this.bathRoom = bathRoom;
            this.area = area;
            this.decor = decor;
            this.villages = villages;
        }

        public int BedRoom { get => bedRoom; set => bedRoom = value; }
        public int BathRoom { get => bathRoom; set => bathRoom = value; }
        public float Area { get => area; set => area = value; }
        internal Decoration Decor { get => decor; set => decor = value; }
        internal Village Villages { get => villages; set => villages = value; }

        public float gethouseCost()
        {
            float houseCost = this.area * this.villages.Val + this.bedRoom * 100000
                + this.bathRoom * 100000 + this.decor.Cost; ;
            return houseCost;
        }
        public override string ToString()
        {
            return  this.bedRoom + " " + this.bathRoom + " " + this.area
                + " " + this.decor.Name + this.villages.Name + " " + this.gethouseCost();
        }

    }
}


