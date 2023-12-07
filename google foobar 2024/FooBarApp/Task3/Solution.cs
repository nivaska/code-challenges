namespace Task3;

public class Solution
{
    public static int Run(int[] x)
    {
        int prod = 1;
        int count_pos = 0, count_neg = 0, count_zero = 0;
        int largest_neg = -1001;

        foreach (var num in x)
        {
            if (num > 0){
                count_pos++;
                prod *= num;
            } 
            else if (num < 0) 
            {
                count_neg++;
                prod *= num;

                if(num > largest_neg)
                {
                    largest_neg = num;
                }
            }
            else
            {
                count_zero++;
            }
        }

        if (count_pos is 0 && count_zero is not 0 && count_neg is 1 or 0)
        {
            return 0;
        }

        if (count_pos is 0 && count_zero is 0 && count_neg is 1)
        {
            return prod;
        }

        if(count_neg %  2 != 0) {
            prod /= largest_neg;
        }

        return prod;
    }
}
