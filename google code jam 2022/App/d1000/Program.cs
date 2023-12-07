using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1000
{
    public class Program
    {
        public static void Main()
        {
            var printText = "";
            var numInputs = Console.ReadLine();

            for (int i = 0; i < int.Parse(numInputs); i++)
            {
                var inputSize = Console.ReadLine();
                var inputDice = Console.ReadLine();
                var allDices = inputDice.Split(' ').Select(x => int.Parse(x.Trim())).ToList();
                allDices.Sort();

                var count = 0;
                for (int j = 0; j < allDices.Count(); j++)
                {
                    // correct implementation:
                    // if(allDices[j] > count)
                    if (allDices[j] >= j+1)
                        count++;
                }

                printText += $"Case #{i + 1}: {count}\n";
            }

            Console.WriteLine(printText);
            Console.ReadLine();

        }
    }
}