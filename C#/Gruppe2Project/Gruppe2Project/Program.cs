using System;
using System.Threading;

namespace Gruppe2Project
{
    public class Program
    {
        public string path;

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Type in the name of the file you wanna use.");
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

                Console.Clear();
                Console.WriteLine("The file 'MyText' have been choosen.");
                Thread.Sleep(2000);
                Console.Clear();

                path = f.GetCurrentPath();
                f.FileCall(path);
            }
        }
    }
}
