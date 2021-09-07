using System;
using System.Globalization;

namespace ControlFlow3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I understand that you would like to submit a picture, but I need it's dimensions... What is the width of the picture in inches? ");
            float widthInches = float.Parse(Console.ReadLine());

            Console.WriteLine("Okay! What is the height of the picture in inches? ");
            float heightInches = float.Parse(Console.ReadLine());

            if (widthInches > heightInches)
                Console.WriteLine("Your picture is landscape!");
            else if (heightInches > widthInches)
                Console.WriteLine("Your picture is portrait!");
            else
                Console.WriteLine("Your picture is a square!");
        }
    }
}
