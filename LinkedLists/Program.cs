// Linked Lists

// A data structure that groups one or more items that
// can be stored anywhere in memory. Each item stores
// the address of the next item in the list.

// Good for: inserting and deleting data
// Bad at: reading data because it can only access
//      data sequentially, aka reading every element in the list.
//      one at a time.

// Create the Linked List
string[] words = { "data", "structures", "and", "algorithms" };

LinkedList<string> sentence = new LinkedList<string>(words);

// Add the word 'today' to the beginning of the linked list
sentence.AddFirst("today");

// Add the word 'mind' to the end of the linked list
sentence.AddLast("mind");

// Find a node in the linked list, make it the "current" node
LinkedListNode<string> current = sentence.Find("data");

// Add 'quick' before 'data'
sentence.AddBefore(current, "quick");

// Add 'clue' after 'data'
sentence.AddBefore(current, "clue");

// Remove the node referred to by current
sentence.Remove(current);