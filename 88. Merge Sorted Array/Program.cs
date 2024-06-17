int[] nums1 = [1, 2, 3, 0, 0, 0];
int m = 3;
int[] nums2 = [2, 5, 6];
int n = 3;

Merge(nums1, m, nums2, n);

static void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (n is 0) return;

    int j = 0;
    for (int i = m; i < nums1.Length; i++)
    {
        nums1[i] = nums2[j];
        j++;
    }

    Array.Sort(nums1);

    return;
}