// Three Number Sum

// Time: O(n^2) Space: O(n)

// Create a method that takes in an int array and an int for targetSum
// and returns a list of int arrays
List<int[]> ThreeNumberSum(int[] array, int targetSum)
{
    // Sort array
    Array.Sort(array);

    // Initialize final triplets
    List<int[]> triplets = new List<int[]>();

    // Start iterating through the array, for length - 2
    // We always want to have three numbers so our last "current number"
    // has to be the third value from the end of the array
    for (int i = 0; i < array.Length - 2; i++)
    {
        int left = i + 1;
        int right = array.Length - 1;

        // While loop to check that our pointers are not overlapping
        // or the left pointer hasn't past the right
        while (left < right)
        {
            int currentSum = array[i] + array[left] + array[right];

            // Check if the triplets add up to target sum
            if (currentSum == targetSum)
            {
                int[] newTriplet = { array[i], array[left], array[right] };
                triplets.Add(newTriplet);
                left++;
                right--;
            }

            // Else if, check if the triplets are less than the target sum
            else if (currentSum < targetSum)
            {
                left++;
            }

            // Else check if the triplets are creater than the target sum
            else
            {
                right--;
            }
        }

    }

    return triplets;
}
