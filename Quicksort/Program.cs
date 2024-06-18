int[] arr =  new int[10];



for (int i = 0; i < arr.Length - 1; i++)
{
    arr[i] = Random.Shared.Next(minValue: 0, maxValue: 100);
}

Console.WriteLine("Before sorting:");
foreach (int x in arr)
{
    Console.Write($"{x}, ");

}

Console.WriteLine();
QuickSort(arr);


static int[] QuickSort(int[] arr)
{
    // If length is 2 to be added

    int pivotPoint = arr.Length / 2;


    int countLeft = 1; // Including the pivot point
    int countRight = 0;

    for (int i = 0; i < arr.Length - 1; i++) // Count new array size
    {
        if (pivotPoint == i) { continue; }
        if (arr[pivotPoint] > arr[i]) // Move to the left
        {
            countLeft++;
        }
        else // Move to the right
        {
            countRight++;
        }
    }

    int[] leftArr = new int[countLeft];
    int[] rightArr = new int[countRight];

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[pivotPoint] > arr[i])
        {
            leftArr[i] = arr[i];
        }
        else
        {
            rightArr[i] = arr[i];
        }
    }

    Console.WriteLine("Left Arr:");
    foreach (int x in leftArr)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();

    Console.WriteLine("Right Arr: ");
    foreach(int x in rightArr)
    { Console.Write($"{x} "); }

    return arr;
}