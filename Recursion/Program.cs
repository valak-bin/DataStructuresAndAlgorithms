// Recursion is when a function calls itself.
// Every recursive function has two cases: The base case and the recursive case.

// CountdownEvent(10);
Console.WriteLine(FactorialCalculator(10));

int FactorialCalculator(int x)
{
    if (x == 1)
    {
        return 1;
    }
    else
    {
        return x * FactorialCalculator(x - 1);
    }
}

void CountdownEvent(int x)
{
    Console.WriteLine(x);

    if (x <= 1)
    {
        return;
    }
    else
    {
        CountdownEvent(x - 1);
    }
}