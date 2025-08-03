double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenstor = c + d;
    double result = numenator / denomenstor;
    return result;
}



double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine($"{result:f2} ");