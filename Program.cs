using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            int counter = 0;
            while( a != b){

                if(a > b){
                    while(a > b){
                        if(a % 2 ==0){
                            a = a / 2;
                            counter++;
                        }
                        else{
                            a++;
                            counter++;
                        }
                    }
                }
                else{
                    // while(a < b){
                    //     a++;
                    //     counter++;
                    // }
                    break;
                }
            }
            if(a < b){
                counter += b - a;
            }
            Console.WriteLine(counter);
        }
    }
}
