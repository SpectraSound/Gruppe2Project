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
            string Choice = Console.ReadLine();

            if (Choice == "MyText") // Choose File (if multiple)
            {
                path = f.GetCurrentPath();
                f.FileCall(path);
            }
        }
    }
}
