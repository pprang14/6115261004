using System;
using System.Collections.Generic;
using System.Text;

namespace _6115261004
{
    class HouseProject
    {
        private string name;
        private House [] houses = new House[10];
        public string getHouseProjectValue(string n)
        {
            this.name = n;
        }

    public void setHouse(House h, int index)
        {
            this.houses[index] = h;
        }
        public House GetHouse(int index)
        {
            return this.houses[index];
        }
        public void listAllHouse()
        {
            for (int i = 0; i < this.houses.Length; i++)
            {
                if (this.houses[i] != null)
                {
                    Console.WriteLine(this.houses[i].ToString());
                }
            }
        }

        
        public string Name { get => name; set => name = value; }


    }
}
