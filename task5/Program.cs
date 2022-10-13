// Показать треугольник Паскаля. 
//Сделать вывод в виде равнобедренного треугольника.На вход дается колличетсво строк в треугольнике.
Console.Clear();
int factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
        x *= i;
    return x;
}

void PrintPascal(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) 
            Console.Write(" ");

        for (int c = 0; c <= i; c++)
        {
            Console.Write(" "); 
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
        }
        Console.WriteLine(); 
    }
}

Console.WriteLine("Введите количество строк в треугольнике: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintPascal(n);

