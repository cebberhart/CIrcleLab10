using System;

namespace CircleLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome the user
            //Prompt the user to enter a radius
            Console.WriteLine("Welcome to the Circle Tester");
            Console.WriteLine("Enter a radius");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            double circumference = circle.CalculateCircumference(radius);
            Console.WriteLine("Circumference: " + circumference);
            double area = circle.CalculateArea(radius);
            Console.WriteLine("Area: " + area);
            
            
        }
         
    }
}
