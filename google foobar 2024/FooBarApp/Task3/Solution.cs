namespace Task3;

public class Solution
{
    public static int Run(int[] x)
    {
        int prod_pos = 1, prod_neg = 1;
        int count_pos = 0, count_neg = 0, count_zero = 0;
        int largest_neg = 1;

        foreach (var num in x)
        {
            if (num > 0){
                count_pos++;
                prod_pos *= num;
            } 
            else if (num < 0) 
            {
                count_neg++;
                prod_neg *= num;

                if(num > largest_neg || largest_neg == 1)
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
            return prod_neg;
        }

        return prod_pos * prod_neg / (prod_neg < 0 ? largest_neg: 1);
    }
}
