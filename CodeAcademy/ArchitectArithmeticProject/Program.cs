//-------------------------------------------------------------------------------cd 
// Author: James Anthony Ortiz
// Date: 04/16/2021
// Description: Program to caLculate the total area of a historic building
// using methods (functions).
//--------------------------------------------------------------------------------


using System;

namespace ArchitectArithmeticProject
{
    class Program
    {
        static double rectangleArea(double length, double width){
            return (length * width);
        }

        static double circleArea(double radius){
            return (Math.Pow(radius, 2) * Math.PI);
        }

        static double triangleArea(double bottom, double height){
            return (0.5 * bottom * height);
        }


    
    
        public static void Main(string[] args)
        {
            double rectangle;
            double circle;
            double triangle;
            rectangle = rectangleArea(4, 5);
            circle = circleArea(4);
            triangle = triangleArea(10, 9);
            Console.WriteLine(rectangle);
            Console.WriteLine(circle);
            Console.WriteLine(triangle);

            //Area of triangle:
            double totalTriArea = triangleArea(750, 500);
            //Area of Circle:
            double totalCirArea = circleArea(375);
            //Area of Rectangle:
            double totalRectArea = rectangleArea(2500, 1500);

            double totalAreaSum = totalTriArea + totalCirArea + totalRectArea;

            double totalAreaCost = 180 * totalAreaSum;

            Console.WriteLine($"The total area is {Math.Round(totalAreaSum, 2)} meters.");
            Console.WriteLine($"The total cost of construction is: {Math.Round(totalAreaCost)} Mexican pesos.");
        }

    }
}
