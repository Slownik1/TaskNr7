using System;

namespace Tasknr7
{
    class Program
    {
        static void Main(string[] args)
        {

            Punkt p1 = new Punkt(5, 3, 2);

            Console.WriteLine(p1.ToString());

            Kula k1 = new Kula(5, 3, 1, 4);

            Console.WriteLine(k1.ToString());

            Console.WriteLine(k1.IsIn(k1, p1));

        }
    }
}
