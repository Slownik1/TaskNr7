using System;
using System.Collections.Generic;
using System.Text;

namespace Tasknr7
{
    public struct Punkt
    {

        public double x, y, z;

        public Punkt(double x, double y, double z)
        {

            this.x = x;
            this.y = y;
            this.z = z;

        }

        public override string ToString()
        {
            return $"Punkt ma koordynaty {x} x, {y} y, {z} z";
        }

    }
}
