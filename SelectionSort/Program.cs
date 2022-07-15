// Selection Sort sorts an array from smallest to largest.

List<int> unsortedList = new List<int> { 323, 242, 16, 431, 2, 45, 12, 53423, 1239 };

List<int> sortedList = SelectionSort(unsortedList);

// First, you write a method to find the smallest element's index in an array:

int FindSmallest(List<int> arr)
{
    int smallest = arr[0]; // Stores the smallest value
    int smallestIndex = 0; // Stores the index of the smallest value

    for (int i = 1; i < arr.Count; i++)
    {
        if (arr[i] < smallest)
        {
            smallest = arr[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}

// Now you can use that function to write the selection sort:

List<int> SelectionSort(List<int> arr)
{
    List<int> newArr = new List<int>();
    int arrInitialCount = arr.Count;

    for (int i = 0; i < arrInitialCount; i++)
    {
        int smallest = FindSmallest(arr);
        newArr.Add(arr[smallest]);
        arr.RemoveAt(smallest);        
    }

    return newArr;
    
}
