// Queue

// Represents a first-in, first-out (FIFO) collection of objects.

// Create an empty Queue
Queue<string> hackers = new Queue<string>();

// Add objects to the queue
hackers.Enqueue("Elliot Alderson");
hackers.Enqueue("Darlene Alderson");
hackers.Enqueue("Angela Martin");

// Remove the first object off the bottom of the queue
// and store it in a variable
string nextHacker = hackers.Dequeue();

// Display the bottom object of the queue without removing it
hackers.Peek();