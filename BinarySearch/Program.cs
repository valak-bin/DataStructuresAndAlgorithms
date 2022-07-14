
int[] myArr = new int[] { 1, 3, 5, 7, 9 };

Console.WriteLine(BinarySearch(myArr, 9));
Console.WriteLine(BinarySearch(myArr, -1));


int BinarySearch(int[] list, int item)
{
    int low = 0;
    int high = list.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;
        int guess = list[mid];

        if (guess == item)
        {
            return mid;
        }
        else if (guess > item)
        {
            high = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }


    return -1;
}
