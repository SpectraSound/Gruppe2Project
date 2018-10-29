using System;

namespace Gruppe2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions f = new Functions();

            string input = Console.ReadLine();
            bool running = true;

            while (running)
            {
                switch (input)
                {
                    case "Showall":
                        f.ShowAll();
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
