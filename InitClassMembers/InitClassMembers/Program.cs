using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Initializing Class Members";

            //Create an instance of the Cat class:
            Cat tigger = new Cat();
            string tagT = String.Format("{0} is a {1} year old {2} cat",
                tigger.getName(),
                tigger.getAge(),
                tigger.getColor());

            Console.WriteLine(tagT + tigger.cry());

            Cat smokey = new Cat();
            smokey.setName("Smokey");
            smokey.setAge(2);
            smokey.setColor("Gray");

            string tagS = String.Format("{0} is a {1} year old {2} cat",
                smokey.getName(),
                smokey.getAge(),
                smokey.getColor());

            Console.WriteLine(tagS + smokey.cry());
            Console.ReadKey();
        }   
    }

    public class Cat
    {
        //Private variables:
        private string name, color;
        private int age;

        //Consructor for Cat Class:
        public Cat()
        {
            name = "Tigger";
            age = 3;
            color = "Brown";
        }

        //Setter Methods:
        public void setName(string name) { this.name = name; }
        public void setAge(int age) { this.age = age; }
        public void setColor(string color) { this.color = color; }

        //Getter Methods:
        public string getName() { return name; }
        public int getAge() { return age; }
        public string getColor() { return color; }

        public string cry() { return "\nMeow, meow!\n"; }

    }

}
