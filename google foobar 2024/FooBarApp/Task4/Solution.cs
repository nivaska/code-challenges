using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4;

public class Solution
{
    public static int Run(int x)
    {
        return ProcessPellets(x, 0);
    }

    static int ProcessPellets(int totalPellets, int numOfOperations)
    {
        if (totalPellets == 1)
        {
            return numOfOperations;
        }

        if(totalPellets % 2 == 0)
        {
            numOfOperations++;
            return ProcessPellets(totalPellets / 2, numOfOperations);
        }

        if ((totalPellets-1)/2 % 2 == 0)
        {
            numOfOperations += 2;
            return ProcessPellets((totalPellets - 1) / 2, numOfOperations);
        }

        numOfOperations += 2;
        return ProcessPellets((totalPellets + 1) / 2, numOfOperations);
    }
}
