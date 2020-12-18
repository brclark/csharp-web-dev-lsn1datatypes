using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string abbv;
            string message;

            Console.WriteLine("Please enter a lang abbreviation");
            abbv = Console.ReadLine();
            message = Message.GetMessageSwitch(abbv);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
