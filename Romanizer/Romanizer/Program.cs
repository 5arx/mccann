using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanizerLib;

namespace RomanizerDemo
{
    class Program
    {
        private static readonly Romanizer Romanizer = new Romanizer();

        static void Main(string[] args)
        {
            for (int i=1; i< 4000; i++)
            {
                Console.WriteLine($"{i} = {Romanizer.Translate(i)}");
            }

            
        }
    }
}
