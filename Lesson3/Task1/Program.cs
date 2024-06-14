// Задача: (a * b) / (c + d)

double CalculateFormula(int a, int b, int c, int d)
{
double numenator = a * b;
int denomenator = c + d;
double result = numenator / denomenator;
return result;
}

CalculateFormula(1, 2, 3, 4); // вызов функции

double result = CalculateFormula(1, 2, 3, 4); // использовали переменную
Console.WriteLine(result); // вывод результата
