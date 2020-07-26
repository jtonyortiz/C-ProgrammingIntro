using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingBaseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hiding Base Class Methods";

            //Create a new instance of the base class:
            Man henry = new Man();
            Hombre enrique = new Hombre();
            henry.speak();
            henry.speak("It's a beautiful eveneing");
            enrique.speak("Hola...");
            //Explicit casting - to explicitly call the overloaded method 
            //of the base class:
            ((Man)enrique).speak("Es una tarde hermosa");
            Console.ReadKey();
        }

        public class Man
        {
            public void speak()
            {
                Console.Write("Hello: ");
            }

            public void speak(string message)
            {
                Console.WriteLine(message + "!\n");
            }
        }

        public class Hombre: Man
        {
            public new void speak(string message)
            {
                base.speak(); //Explicitly call the simple method the base class
                Console.WriteLine(message);
            }
        }
    }
}
