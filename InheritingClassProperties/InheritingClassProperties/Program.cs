using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance of Classes";
            //Create Instance of Classes:
            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            //Set values
            rect.setValues(4, 5);
            cone.setValues(4, 5);

            //Display to output:
            Console.WriteLine("Rectangle Area: " + rect.area());
            Console.WriteLine("\nTriangle Area: " + cone.area());
            Console.ReadKey();
        }
    }

    public class Polygon
    {
        protected int width, height;

        public void setValues(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


    }

    //Class inherits from Polygon:
    public class Rectangle: Polygon
    {
        public int area() { return (width * height); }
    }

    public class Triangle: Polygon
    {
        //Classes can create a method of the same name, given
        //that the scope for each class is different:
        public int area() { return ((width * height) / 2); }
    }
}
