// Sorted Squared Array

var arr = new int[] { -10, 1, 2, 3, 5, 6, 8, 9 };

// Brute Force
// Time: O(n log n) Space: O(n)

// Conditions: You have to take in and input an int array

int[] SortedSquaredArrayNaive(int[] arr)
{
    var squaredArray = new int[arr.Length];

    for(int i = 0; i < arr.Length; i++)
    {
        int value = arr[i] * arr[i];
        squaredArray[i] = value;

    }

    Array.Sort(squaredArray);
    return squaredArray;
}

// Optimize with Two Pointers
// Time: O(n) Space O(n) where n is the length of the input array

int[] SortedSquaresTwoPointers(int[] array)
{
    int[] sortedSquares = new int[array.Length];

    int smallerValueIndex = 0;
    int largerValueIndex = array.Length - 1;

    for (int index = array.Length - 1; index >= 0; index--)
    {
        // Initialize smaller value pointer
        int smallerValue = array[smallerValueIndex];

        // Initialize larger value pointer
        int largerValue = array[largerValueIndex];

        // Compare the absolute values at the small and large index
        if (Math.Abs(smallerValue) > Math.Abs(largerValue))
        {
            sortedSquares[index] = smallerValue * smallerValue;
            // Move smaller value index to the right
            smallerValueIndex++;
        }
        else
        {
            sortedSquares[index] = largerValue * largerValue;
            // Move larger value index to the left
            largerValueIndex--;
        }
    }

    return sortedSquares;
}
