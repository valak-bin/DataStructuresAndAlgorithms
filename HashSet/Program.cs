
// Implementing a Hash Table with C# HashSet.

// Similar to C# Dictionary<T> without the values.

HashSet<int> evenNumbers = new HashSet<int> { 2, 4, 6, 8 };
HashSet<int> oddNumbers = new HashSet<int> { 1, 3, 5, 7};


// Add elements to the Hashset

evenNumbers.Add(10);

// You can use foreach in HashSet

foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

// Check if a HashSet contains a value

Console.WriteLine(evenNumbers.Contains(1));