namespace Task2;

public class Solution
{
    public static int Run(int x, int y)
    {
        var workkerIdAtY = 1 + (y * (y - 1) / 2);
        var workkerIdAtXAndY = workkerIdAtY + (x - 1) * y + ((x) * (x - 1) / 2);
        return workkerIdAtXAndY;
    }
}
