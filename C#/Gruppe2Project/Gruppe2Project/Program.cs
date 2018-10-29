using System;

namespace Gruppe2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool running = true;

            while (running)
            {
                switch (input)
                {
                    case "Showall":
                        break;
                    case "Quit":
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
