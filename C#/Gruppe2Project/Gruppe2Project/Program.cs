using System;

namespace Gruppe2Project
{
    public class Program
    {
        public string path;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Start();

        }

        public void Start()
        {
            Functions f = new Functions();

            Console.WriteLine(f.GetCurrentPath());
            //gets user input
            string Choice = Console.ReadLine();

            //if the user input is the same as "MyText" it wil get the current path of the file
            if (Choice == "MyText") // Choose File (if multiple)
            {
                path = f.GetCurrentPath();
                f.FileCall(path);
            }
        }
    }
}
