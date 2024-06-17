using System.Numerics;

Console.WriteLine(TrailingZeroes(n: 6358));

static int TrailingZeroes(int n)
{
    int count2 = 0;
    int count5 = 0;

    for (int i = 2; i <= n; i++)
    {
        int num = i;
        while (num % 2 == 0)
        {
            count2++;
            num /= 2;
        }
        while (num % 5 == 0)
        {
            count5++;
            num /= 5;
        }
    }

    return Math.Min(count2, count5);
}