//Дано 5 гирь с разным весом в случайном порядке. Найти вес самой тяжелой гири.
int a = 18;
int b = 7;
int c = 2;
int d = 16;
int e = 17;

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
if (max < d)
{
    max = d;
}
if (max < e)
{
    max = e;
}
Console.WriteLine(max);
