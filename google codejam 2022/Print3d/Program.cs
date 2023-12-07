using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print3d
{
    public class Program
    {
        public static void Main()
        {
            var printText = "";
            var numInputs = Console.ReadLine();

            for (int i = 0; i < int.Parse(numInputs); i++)
            {
                var printer1 = Console.ReadLine();
                var printer2 = Console.ReadLine();
                var printer3 = Console.ReadLine();
                
                var printer1Parse = printer1.Split(' ').Select(x => int.Parse(x.Trim())).ToList();
                var printer2Parse = printer2.Split(' ').Select(x => int.Parse(x.Trim())).ToList();
                var printer3Parse = printer3.Split(' ').Select(x => int.Parse(x.Trim())).ToList();

                var maxC = (new List<int>() { printer1Parse[0], printer2Parse[0], printer3Parse[0] }).Min();
                var maxm = (new List<int>() { printer1Parse[1], printer2Parse[1], printer3Parse[1] }).Min();
                var maxy = (new List<int>() { printer1Parse[2], printer2Parse[2], printer3Parse[2] }).Min();
                var maxk = (new List<int>() { printer1Parse[3], printer2Parse[3], printer3Parse[3] }).Min();

                if (maxC + maxk + maxm + maxy >= 1000000)
                {
                    var c = maxC < 1000000 ? maxC: 1000000;
                    var m = c + maxm < 1000000 ? maxm : 1000000 - c;
                    var y = c + m + maxy < 1000000 ? maxy : 1000000 - c - m;
                    var k = c + m +  y +maxk < 1000000 ? maxk : 1000000 - c - m - y;

                    printText += $"Case #{i + 1}: {c} {m} {y} {k}\n";

                }
                else
                {

                    printText += $"Case #{i + 1}: IMPOSSIBLE\n";

                }
            }

            Console.WriteLine(printText);
            Console.ReadLine();

        }
    }
}