using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] grames = { "Witcher, Red Dead 2, Tropico, Skyrim, COD" };
            var nameLength = grames.Where(x => x.Length > 0).Count();
            foreach (var grame in grames)
            {
                Console.WriteLine(grame);
            }
                             


        }
    }
}
