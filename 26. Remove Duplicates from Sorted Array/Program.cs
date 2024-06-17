Console.WriteLine(RemoveDuplicates(nums: [1, 1, 2]));

static int RemoveDuplicates(int[] nums)
{
    int k = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        bool contains = false;

        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                contains = true;
            }
            if (contains) break;
        }

        if (!contains)
        {
            nums[k] = nums[i];
            k++;
        }
    }

    return k;
}