// Implementing Binary Search using Recusion

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int start = 0;
int end = arr.Length - 1;
int target = 2;

Console.WriteLine(BinarySearch(arr, start, end, target));

// Return the array index of the target

int BinarySearch(int[] arr, int start, int end, int target)
{
    if (start > end) return -1;

    int midIndex = (start + end) / 2; // C# rounds int division down by default

    // Condition 1: Our target is located at the middle index.
    if (arr[midIndex] == target) return midIndex;

    // Condition 2: Our target is located to the left of the middle index
    if (arr[midIndex] > target)
    {
        return BinarySearch(arr, start, midIndex - 1, target);
    }
    
    // Condition 3: Our target is located to the right of the middle index
    else
    {
        return BinarySearch(arr, midIndex + 1, end, target);
    }
}
