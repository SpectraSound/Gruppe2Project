using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Gruppe2Project
{
    class Functions
    {
        string path = @"/..MyText.txt";
        bool running = true;

        public void FileCall(string foo)
        {
            Functions f = new Functions();

            while (running)
            {
                Console.WriteLine("Write your command here:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "Showall":
                        f.ShowAll(foo);
                        break;
                    case "Quit":
                        running = false;
                        break;
                    case "Clear":
                        File.WriteAllText(path, "");
                        break;
                    default:
                        f.WriteText(foo, input);
                        break;
                }
            }
        }

        public void ShowAll(string path)
        {
            Console.Clear();
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine();
        }

        public void WriteText(string path, string input)
        {
            File.AppendAllText(path, input);
            Console.WriteLine();
        }
    }
}
