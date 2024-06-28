int[] nums = [-3, 4, 3, 90];
int target = 0;

int[] result = TwoSum(nums: nums, target: target);
foreach (int x in result)
{
    Console.WriteLine(x);
}


static int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if ((nums[i] + nums[j]) == target)
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    return result;
}