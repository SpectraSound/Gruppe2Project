using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Gruppe2Project
{
    class Functions
    {
        bool running = true;

        public void FileCall(string path)
        {
            Functions f = new Functions(); // Allows to call other function in the class.

            while (running) // This is a loop.
            {
                Console.WriteLine("Write your command here:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "Showall": // When typed in the console it will call the Showall function
                        f.ShowAll(path);
                        break;
                    case "Quit": // When typed in will close the program.
                        running = false;
                        break;
                    case "Clear": // When typed in will delete everything in the file.
                        File.WriteAllText(path, "");
                        break;
                    default: // This will be in use every time something is typed in which is not something that can be called.
                        f.WriteText(path, input);
                        break;
                }
            }
        }

        // This function when used will show eveything written in the file.
        public void ShowAll(string path)
        {
            Console.Clear();
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine();
        }

        // This function lets you write a line of word and then add it to the file.
        public void WriteText(string path, string input)
        {
            File.AppendAllText(path, input);
            Console.WriteLine();
        }

        // This function calls the path to the file so it can read it.
        public string GetCurrentPath()
        {
            string newPath = Path.Combine(Environment.CurrentDirectory, @"MyText.txt");
            return newPath;
        }
    }
}
