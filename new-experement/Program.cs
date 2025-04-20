using System;
using System.Collections.Generic;
using System.IO;

namespace consoleApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] name = { "John", "Jane", "Doe" }; 
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

