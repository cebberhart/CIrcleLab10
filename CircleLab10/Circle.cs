using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLab10
{
    class Circle
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            string output = $"Circuference: {CalculateCircumference(radius)}\n";
            output += $"Area: {CalculateArea(radius)}\n";
            return output;
        }
        public double CalculateCircumference(double radius)
        {
            Console.WriteLine(radius);
            double cirCirc = 2 * Math.PI * radius;
            return cirCirc;
        }
        public double CalculateArea(double radius)
        {
            Console.WriteLine(radius);
            double cirArea = 2 * Math.PI * radius;
            return cirArea;
        }

    }
}
