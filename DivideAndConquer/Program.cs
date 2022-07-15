// Given an array, add up all of the values in the array and return the sum.

int[] myArr = new int[] { 2, 4, 6, 8, 10};

Console.WriteLine($"Array sum: {ArraySum(myArr)}");
Console.WriteLine($"Array count: {ArrayCount(myArr)}");


int ArraySum(int[] arr)
{
    if (arr.Length == 0)
    {
        return 0;
    }

    return arr[0] + ArraySum(arr[1..]);
}

int ArrayCount(int[] arr)
{
    if (arr.Length == 0)
    {
        return 0;
    }

    return 1 + ArrayCount(arr[1..]);
}
