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

            string Choice = Console.ReadLine();

            if (Choice == "MyText") // Choose File (if multiple)
            {
                path = @"C:/Users/Bruger/Desktop/Gruppe2Project/MyText.txt";
                f.FileCall(path);
            }
        }
    }
}
