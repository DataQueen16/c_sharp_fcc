using System;

namespace freecodecamp_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Enter your name please: ");
             string name = Console.ReadLine();
             Console.Write("Please enter your age: ");
             int age = Convert.ToInt32(Console.ReadLine());
             
             SayHi(name, age);*/

            SayHi("Michelle", 23);
            SayHi("Julian", 32);
            SayHi("Ned", 38);
            SayHi("Jen", 42);

            int cubedNumber = Cube(5);

            Console.WriteLine(cubedNumber);

            bool isFemale = true;
            bool isTall = false;

            if (isFemale || isTall) 
            {
                Console.WriteLine("You are female and you are tall");
            } else 
            {
                Console.WriteLine("You are either not female or not tall or both");
            }

            Console.ReadLine();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
