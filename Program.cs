using System;

namespace _6115261004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Village a = new Village("a", 1000);
            Village b = new Village("b", 20000);
            Village c = new Village("c", 30000);
            Village d = new Village("d", 40000);
            Village e = new Village("e", 50000);

            Decoration d1 = new Decoration("1", 10000);
            Decoration d2 = new Decoration("2", 20000);
            Decoration d3 = new Decoration("3", 30000);
            Decoration d4 = new Decoration("4", 40000);
            Decoration d5 = new Decoration("5", 50000);

            House H1 = new House(100, 100, 100, d1, a);
            House H2 = new House(200, 200, 200, d2, b);
            House H3 = new House(300, 300, 300, d3, c);
            House H4 = new House(400, 400, 400, d4, d);
            House H5 = new House(500, 500, 500, d5, e);


            HouseProject Hp1 = new HouseProject();

            Console.WriteLine(H1.ToString());
            Console.WriteLine(H2.ToString());
            Console.WriteLine(H3.ToString());
            Console.WriteLine(H4.ToString());
            Console.WriteLine(H5.ToString());
            Hp1.printAll();
        }
    }
}
