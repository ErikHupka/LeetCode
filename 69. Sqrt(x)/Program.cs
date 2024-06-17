int input = 15000;

Console.WriteLine(MySqrt(input));

static int MySqrt(int x)
{
    if (x < 2)
        return x;

    double y = x;
    double z = (y + (x / y)) / 2;

    while (Math.Abs(y - z) >= 0.00001)
    {
        y = z;
        z = (y + (x / y)) / 2;
    }

    return (int)z;
}