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
<<<<<<< HEAD
            Console.WriteLine("Type in the name of the file you wanna use.");
            p.Start();            
=======

            p.Start();

>>>>>>> Filstitest
        }

        public void Start()
        {
            Functions f = new Functions();
<<<<<<< HEAD
            string Choice = Console.ReadLine();            
=======

            Console.WriteLine(f.GetCurrentPath());
            //gets user input
            string Choice = Console.ReadLine();
>>>>>>> Filstitest

            //if the user input is the same as "MyText" it wil get the current path of the file
            if (Choice == "MyText") // Choose File (if multiple)
            {
<<<<<<< HEAD
                Console.Clear();
                Console.WriteLine("The file 'MyText' have been choosen.");
                Thread.Sleep(2000);
                Console.Clear();

                path = @"/..MyText.txt";
=======
                path = f.GetCurrentPath();
>>>>>>> Filstitest
                f.FileCall(path);
            }
        }
    }
}
