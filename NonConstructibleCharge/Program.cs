// Non-constructible Change
// Time: O(n log n) Space: O(1)

int NonConstructibleChange(int[] coins)
{
    // Start by sorting the coins array
    Array.Sort(coins);

    // Create a variable to hold the current change created
    var currentChangeCreated = 0;

    // Loop through all of the coins
    foreach (var coin in coins)
    {
        // Check if the value of the coin we're adding is greater than the
        // current change created plus one. If it is, that tells us that we've
        // found the minimum amount of change that we cannot create.
        if (coin > currentChangeCreated + 1) return currentChangeCreated + 1;

        // Otherwise add the value of the coin to our current change created
        // This says we can create all of the values of change up to the coin we
        // just added.
        currentChangeCreated += coin;

    }

    // If we get through the whole array, the next value we cannot create
    // is the largest coin plus 1.
    return currentChangeCreated + 1;

}
