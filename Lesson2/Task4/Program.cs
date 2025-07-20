//int n = 5;
int[] array = { 19, 4, 17, 3, 16 };
int i = 0;
int max = array[0];
while (i < array.Length)
{
    if (max < array[i])
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine($"max0 = {max} ");
Console.WriteLine();

max = array[0];
for (int j = 0; j < array.Length; j = j + 1)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine($"max1 = {max} ");
Console.WriteLine();

max = array[0];
foreach (int item in array)
{
    if (item > max)
    {
        max = item;
    }
}
Console.WriteLine($"max2 = {max} ");