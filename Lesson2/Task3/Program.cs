int n = 10;
int[] arr = new int[n]; //{2, 5, 4, 7, 8, 35, 1, 3, 12, 9};
int i = 0;
while (i < n)
{
    arr[i] = i + 1;
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
