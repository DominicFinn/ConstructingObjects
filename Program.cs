using System;
using System.IO;

namespace ConstructingObjects
{
    class Program
    {
        static string introString = "res/Zelda.txt";

        static void Main(string[] args)
        {
            ShowIntro();
        }

        static void ShowIntro()
        {
            foreach (var line in GetRes())
                Console.WriteLine(line);                 
        }

        static string[] GetRes()
        {
            if (File.Exists(introString))
            {
                return File
                    .ReadAllLines(introString);                    
            }

            return new string[0];
        }
    }
}
