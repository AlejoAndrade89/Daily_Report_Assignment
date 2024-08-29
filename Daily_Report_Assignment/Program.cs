using System;

namespace Daily_Report_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Writeline what it does is asking in console the string you used , in the case below , prints "Academy of learning College"
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What's your name ? ");

            // capture the info or what you typed in the variable name 
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on ? ");
            string course = Console.ReadLine();
            Console.WriteLine("What Page number?");


            // This is called casting , using int capture the String you typed , and convert to an int so the output is a number , not a string

            // these example applies for the rest of the code , where we use casting as well 
            int PageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please Answer  \" true\"or \" false ");
            string needAnything = Console.ReadLine();
            bool needHelp =  bool.Parse(needAnything);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string giveSpecifics = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedBack = Console.ReadLine();
            string hoursStudy = Console.ReadLine();
            int hoursStudyNum = Convert.ToInt32(hoursStudy);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");


        }
    }
}
