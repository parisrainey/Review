using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        
        int PrintFizzBuzz(int num)
        {
            //if(multiple of 3)
            //Print ("Fizz")
            int result = num % 3;
            int result2 = num % 5;
            if (result == 0)
            {
                Console.WriteLine("Fizz");
            }

            //if(multiple of 5)
            //Print ("buzz")
            else if (result2 == 0)
            {
                Console.WriteLine("Buzz");
            }

            return num;
        }
        
        string GetInput(string prompt, string option1, string option2)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write(">");

                playerChoice = Console.ReadLine();
            }
            return playerChoice;
        }

        void PrintSum(int[] Array)
        {
            int results = 0;

            for (int i = 0; i <= Array.Length; i++)
            {
                results += Array[i];
            }

        }

        void PrintBackwards(int[] Numbers)
        {
            for (int i = Numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Numbers[i]);
            }
            
        }

        int[] Numbers = new int[] { 4, 5, 6, 7 };
        public void Run()
        {
            PrintBackwards(Numbers);
        }
    }
}
