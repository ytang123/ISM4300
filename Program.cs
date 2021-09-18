using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Election1
{
    class Program
    {
        private static object dictionary;
        private static object input;

        static void Main(string[] args)
        {
            // Declare dictionary for candiate and votes
            var cans = new Dictionary<string, string>();
            var votes = new Dictionary<string, int>();

            int x = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                cans.Add(Console.ReadLine(), Console.ReadLine());
            }

            int voteNum = Int32.Parse(Console.ReadLine());

       
    }
}

               
