using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    class Circle
    {
        public const double pi = Math.PI;
        /*   public double Radius; */
        public static double getAreaOfCircle(double radius)
        {
            double areaOfCircle;

            areaOfCircle = pi * radius * radius; //Math.Pow(radius, 2) * pi
            return areaOfCircle;
        }

        public static double getCircumference(double radius)
        {
            double circumference;
            circumference = 2 * pi * radius;
            return circumference;
        }

        public static double getDiameter(double radius)
        {
            double diameter;
            diameter = 2 * radius;
            return diameter;
        }
        // instantiation method : public Circle (args radius) { this.Radius = radius } //capitalize all methods GetDiameter
        // remove static methods

    }
}
