// Arrays

// An array is a data structure that holds a group of one or more items
// that are stored contiguously (right next to eachother) in memory.

// Good at: reading data using random access
// Bad at: inserting and deleting data

// Integer Array
int[] integerArray = new int[] { 18, 21, 100, 1, 69 };

// String Array
string[] stringArray = new string[] { "Elliot", "Darleen", "Angela" };

// Empty Array
// Using Array.Empty does not allocate any memory on the heap vs new int[] {};
int[] emptyIntegerArray = Array.Empty<int>();