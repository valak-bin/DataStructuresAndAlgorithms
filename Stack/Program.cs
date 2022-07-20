// Stack

// Represents a last-in, first-out (LIFO) collection of objects.

// Create an empty stack.
Stack<string> energyDrinks = new Stack<string>();

// Push items on top of the stack
energyDrinks.Push("Monster");
energyDrinks.Push("Rockstar");
energyDrinks.Push("Red Bull");

// Pop an item off the top of the stack;
string lastDrink = energyDrinks.Pop();