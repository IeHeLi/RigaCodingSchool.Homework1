using System;

namespace RigaCodingSchool.Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            byte age = 24;
            string name = "Ieva Helēna";
            string surname = "Litinska";
            double height = 1.61;
            string size = "short";
            string hello = "Hi students of our course!";
            string hobby = "cooking, reading and relaxing";
            byte year = 3;
            string degree = "sociology";
            //This is the part with the variables
            #endregion

            #region theCode
            Console.WriteLine(hello);
            Console.WriteLine($"I am  {name} { surname} .");
            Console.WriteLine($"My age is {age}. And my height is {height}m, so I am quite {size}.");
            Console.WriteLine($"In my free time I enjoy {hobby}.");
            Console.WriteLine($"I currently study {degree} and I am in my {year}rd year.");
            Console.WriteLine("Hope you have a Wonderful day Today! :) ");
            Console.ReadLine();
            //This is the part, which will show
            #endregion 

        }
    }
}
