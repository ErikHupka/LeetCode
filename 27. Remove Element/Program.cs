//Console.WriteLine(RemoveElement(nums: [3,2,2,3], val: 3));
//Console.WriteLine(RemoveElement(nums: [0, 1, 2, 2, 3, 0, 4, 2], val: 2));
Console.WriteLine(RemoveElement(nums: [3, 3], val: 5));

static int RemoveElement(int[] nums, int val)
{
    int k = 0;
    if (nums.Length == 1 && nums[0] != val) return 1;
    if (nums.Length == 1 && nums[0] == val) return 0;

    for (int i = 0; i < nums.Length; i++)
    {

        if (nums[i] != val)
        {
            nums[k] = nums[i];
            k++;
        }
    }

    return k;
}