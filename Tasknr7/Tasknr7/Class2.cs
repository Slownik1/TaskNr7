using System;
using System.Collections.Generic;
using System.Text;

namespace Tasknr7
{
    public struct Kula
    {

        public double x, y, z;
        public double r;

        public Kula(double x, double y, double z, double r)
        {

            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;

        }

        public bool IsIn(Kula kula1, Punkt punkt1)
        {

            double powerX = Math.Pow((kula1.x - punkt1.x), 2);
            double powerY = Math.Pow((kula1.y - punkt1.y), 2);
            double powerZ = Math.Pow((kula1.z - punkt1.z), 2);

            double AB = Math.Sqrt(powerX+powerY+powerZ);

            if (AB > kula1.r)
                return false;
            else
                return true;

        }

        public override string ToString()
        {
            return $"Kula ma koordynaty srodka {x} x, {y} y, {z} z i r {r}" ;
        }

    }
}
