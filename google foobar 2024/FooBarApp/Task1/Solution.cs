namespace Task1;

public class Solution
{
    public static int Run(int[] x, int[] y)
    {
        var countDictionary = new Dictionary<int, int>();
        foreach (var a in x.Concat(y))
        {
            if (countDictionary.TryGetValue(a, out int value))
            {
                countDictionary[a] = ++value;
            }
            else { countDictionary[a] = 1; }

            if (countDictionary[a] == 2)
            {
                countDictionary.Remove(a);
            }
        }

        return countDictionary.Keys.Single();
    }
}
