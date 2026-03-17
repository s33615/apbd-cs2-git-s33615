public class StatisticsHelper 
{
    public double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;

        int sum = 0;
        foreach (int val in values)
        {
            sum += val;
        }
        return (double)sum / values.Length;
    }
}

public int CalculateMax(int[] values)
{
    int max = values[0];
    foreach (int val in values)
    {
        if (val > max) max = val;
    }
    return max;
}

public int CalculateMin(int[] values)
{
    return 0; 
}