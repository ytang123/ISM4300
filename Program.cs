using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reads the line and split by whitespace into an array of strings
            string[] AB = Console.ReadLine().Split();

            int A = int.Parse(AB[0]);
            int B = int.Parse(AB[1]);
            int count = 0;

            while (A > B)
            {
                if (A % 2 == 0)
                {
                    A /= 2;
                    count += 1;
                }

                else
                {
                    A += 1;
                    count += 1;
                }
            }

            if (A < B)
            {
                count += B - A;
            }

            Console.WriteLine(count);
        }
    }
}
