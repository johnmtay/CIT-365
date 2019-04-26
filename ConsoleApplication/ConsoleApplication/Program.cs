using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Full Name and Location
            string fullName, location;
            fullName = "John Taylor";
            location = "Cedar City, Utah";

            Console.WriteLine("My name is " + fullName + ". I am from " + location +". ");

            //Current Date
            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToString("M-d-yyyy"));

            //Days Until Christmas
            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);
            //TODO: Calculate number of days until Christmas
            var daysUntil = today - christmas;

            Console.WriteLine("There are " + daysUntil.ToString("dd") + " days until Christmas. ");

            //Code From Section 2.1 of Book
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //TODO: Calculate the wood length and glass area
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}
