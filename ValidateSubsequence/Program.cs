// Validate Subsequence

// While Loop Traversal
// Time: O(n) Space: O(1)

static bool IsValidSubsequenceWhileLoop(List<int> array, List<int> sequence)
{
    // Position in the main array
    int arrayIndex = 0;
    // Position in the sequence array
    int sequenceIndex = 0;

    // Perform operations so long as we're in bounds of 
    //the main array and the sequence array.
    while (arrayIndex < array.Count && sequenceIndex < sequence.Count)
    {
        if (array[arrayIndex] == sequence[sequenceIndex])
        {
            // Move along in the sequence array only 
            // if we find a match
            sequenceIndex++;
        }
        // Move along in the main array regardless.
        arrayIndex++;
    }

    // Only a valid subsequence if the sequenceIndex is equal
    // to the length of the sequence
    return sequenceIndex == sequence.Count;

}

// For Loop Traversal
// Time: O(n) Space: O(1)

static bool IsValidSubsequenceForLoop(List<int> array, List<int> sequence)
{
    int sequenceIndex = 0;

    foreach (int value in array)
    {
        // Check condition if value is in bounds
        if (sequenceIndex == sequence.Count)
        {
            break;
        }

        if (sequence[sequenceIndex] == value)
        {
            sequenceIndex++;
        }
    }

    return sequenceIndex == sequence.Count;
}