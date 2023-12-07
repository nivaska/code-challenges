using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchedCards
{
    public class Program
    {
        public static void Main()
        {
            var cardPlotter = new CardPlotter();
            var printText = "";
            var numInputs = Console.ReadLine();

            for(int i = 0; i < int.Parse(numInputs); i++)
            {
                var inputSize = Console.ReadLine();
                var r = int.Parse(inputSize.Split(' ')[0]);
                var c = int.Parse(inputSize.Split(' ')[1]);
                printText += $"Case #{i+1}:\n";
                printText += cardPlotter.Draw(r, c);
            }

            Console.WriteLine(printText);
            Console.ReadLine();

        }
    }


    internal class CardPlotter
    {
        public string Draw(int r, int c)
        {
            var strBuilder = new StringBuilder();


            for (int i = 0; i < r; i++)
            {
                if (i == 0)
                {
                    strBuilder.AppendLine(GetEdgeRow(c, true));
                    strBuilder.AppendLine(GetMiddleRow(c, true));
                }
                else
                {
                    strBuilder.AppendLine(GetEdgeRow(c));
                    strBuilder.AppendLine(GetMiddleRow(c));
                }

            }
            strBuilder.AppendLine(GetEdgeRow(c));

            return strBuilder.ToString();
        }

        private string GetEdgeRow(int cols, bool isFirstRow = false)
        {
            var rowText = "+";
            if (isFirstRow)
            {
                rowText = ".";
            }

            for (int i = 0; i < cols; i++)
            {
                if (isFirstRow & i==0)
                {
                    rowText += ".+";
                }
                else
                {
                    rowText += "-+";
                }
            }

            return rowText;
        }

        private string GetMiddleRow(int cols, bool isFirstRow = false)
        {
            var rowText = "|";
            if (isFirstRow)
            {
                rowText = ".";
            }

            for (int i = 0; i < cols; i++)
            {
                rowText += ".|";
            }

            return rowText;
        }
    }
}