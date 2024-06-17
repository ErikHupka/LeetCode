int[] result = PlusOne([1, 2, 3]);

foreach (int x in result)
{
    Console.WriteLine(x);
};

static int[] PlusOne(int[] digits)
{
    int length = digits.Length;

    for (int i = length - 1; i >= 0; i--)
    {
        if (digits[i] == 9)
        {
            digits[i] = 0;

            if (i == 0)
            {
                int[] modified = new int[length + 1];

                modified[0] = 1;
                for (int j = 0; j < length; j++)
                {
                    modified[j + 1] = digits[j];
                }

                return modified;
            }
        }
        else
        {
            digits[i] += 1;
        }

        if (digits[i] % 10 != 0)
        {
            return digits;
        }
    }

    return digits;
}