// Two Number Sum

int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };

int targetSum = 10;

//TwoNumberSumNested(array, targetSum);
TwoNumberSumHash(array, targetSum);


// Nested for loops approach
// Time: O(n^2) Space: O(1)

static int[] TwoNumberSumNested(int[] array, int targetSum)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int firstNum = array[i];

        for (int j = i + 1; j < array.Length; j++)
        {
            int secondNum = array[j];
            if (firstNum + secondNum == targetSum)
            {
                return new int[] { firstNum, secondNum };
            }
        }
    }

    return new int[0];
}

// Hash table approach
// Time: O(n) Space: O(n)

// ! If you're in a new coding environment, make sure you include
// using System.Collections.Generic;

static int[] TwoNumberSumHash(int[] array, int targetSum)
{
    // Initialize our hashtable called nums
    HashSet<int> nums = new HashSet<int>();

    // Start iterating through our array
    foreach (int num in array)
    {
        // Implement our equation y = target - x
        int potentialMatch = targetSum - num;
        // If y is present in our nums hashtable, return [x, y]
        if (nums.Contains(potentialMatch))
        {
            return new int[] { potentialMatch, num };
        }
        // Otherwise, we just store our number in the hash table.
        else nums.Add(num);
        }

    return new int[0];
}

// Pointers appoach
// Time: O(n log n) Space: O(1)

static int[] TwoNumberSumPointers(int[] array, int targetSum)
{
    // Sort our array with build-in C# sorting, assuming O(n log n) speed
    Array.Sort(array);
    
    // Initilize left pointer, first value of the array
    int left = 0;
    
    // Initialize right pointer, final value of the array
    int right = array.Length - 1;

    // While the two pointers don't overlap, or the left is not
    // past the right:

    while (left < right)
    {
        int currentSum = array[left] + array[right];
        if (currentSum == targetSum)
        {
            return new int[] { array[left], array[right] };
        }
        else if (currentSum < targetSum) left++;
        else if (currentSum > targetSum) right--;
    }

    return new int[0];
}
