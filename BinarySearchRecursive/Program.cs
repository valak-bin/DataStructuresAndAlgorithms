// Implementing Binary Search using Recusion

//

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int start = 0;
int end = 0;
int target = 0;

Console.WriteLine(BinarySearch(arr, start, end, target));

// Return the array index of the target

int BinarySearch(int[] arr, int start, int end, int target)
{
    if (start > end)
    {
        return -1;
    }

    int midIndex = (start + end) / 2; // C# rounds int division down by default

    if (arr[midIndex] == target)
    {
        return midIndex;
    }

    if (arr[midIndex] > target)
    {
        return BinarySearch(arr, start, midIndex - 1, target);
    }
    else
    {
        return BinarySearch(arr, midIndex + 1, end, target);
    }
}
