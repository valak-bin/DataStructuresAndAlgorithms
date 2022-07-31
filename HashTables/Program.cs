// Hash Tables

// A hash table is a data structure that combines a hash function
// and an array together. A hash table has keys and values. AKA Dictionaries.

// Simple Example
var productPrices = new Dictionary<string, decimal>();

productPrices["apple"] = 0.67m;
productPrices["milk"] = 1.49m;
productPrices["avocado"] = 1.49m;

Console.WriteLine(productPrices["apple"]);

// Preventing Duplicate Entries

// Example: Keeping track of a voter registry. You cannot vote twice.

// First, create a hash to keep track of the people who have voted.
var voterReceipts = new Dictionary<string, bool>();

voterReceipts["Jim"] = true;
voterReceipts["Pam"] = true;

CheckVoter("Jim");
CheckVoter("Creed");

void CheckVoter(string voterName)
{
    if (voterReceipts.TryGetValue(voterName, out bool value))
    {
        Console.WriteLine("They have already voted. Do not let them vote again.");
    }
    else
    {
        voterReceipts[voterName] = true; // Add them to the voter receipts dictionary.
        Console.WriteLine("Please let them vote.");
    }
}
