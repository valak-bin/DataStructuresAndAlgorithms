using ArrayHelpersLibrary;

// Quick Sort

// Average Runtime: O(n log(n))
// Worst Case runtime: O(n2)
// Memory: O(log(n))

// Notebook Page 3

// Examples and Proofs

int[] myArr = new int[] { 10, 5, 2, 3 };
int[] expectedArr = new int[] { 2, 3, 5, 10 };

int[] sortedArr = QuickSort(myArr, 0, myArr.Length - 1);

// Need to create helper method to compare two array for equality.
// Console.WriteLine($"Sorted: {sortedArr == expectedArr}");
Console.WriteLine();
Array.ForEach(sortedArr, Console.WriteLine);

// Methods

int[] QuickSort(int[] arr, int left, int right)
{
    int index = Partition(arr, left, right);
    
    // Sort left half
    if (left < index - 1)
    {
        QuickSort(arr, left, index - 1);
    }

    // Sort right half
    if (index < right)
    {
        QuickSort(arr, index, right);
    }

    return arr;

}

int Partition(int[] arr, int left, int right)
{
    // Pick the pivot
    int pivot = arr[left + (right - left) / 2];
    
    while (left <= right)
    {
        // Find the element on the left that should be on the right
        while (arr[left] < pivot)
        {
            left++;
        }

        // Find the element on the right that should be on the left
        while (arr[right] > pivot)
        {
            right--;
        }

        // Swap elements, and move left and right indices
        if (left <= right)
        {
            ArrayHelpers.SwapInts(arr, left, right);
            left++;
            right--;
            
        }

    }

    return left;
}