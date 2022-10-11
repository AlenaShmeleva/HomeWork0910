// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
Console.Clear();

    void InputMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 11);
                Console.Write(matrix[i, j] + " \t");
            }
            Console.WriteLine();
        }
}

void ResultMatrix(int[,] matrix, int [,] matr)
{
    if (matrix.GetLength(0) != matr.GetLength(1) )
        Console.WriteLine("Произведение матриц невозможно!");
    else
    {
    int [,] resmatrix = new int [matrix.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix.GetLength(0); k++)
            {  
                resmatrix[i, j] += matrix[i, k] * matr[k, j]; 
            } 
            Console.Write(resmatrix[i, j] + " \t");    
        }  
          Console.WriteLine();
    }
    }
}
Console.Write("Введите кол-во строк первой  матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[a, b]; 
InputMatrix(matrix);
Console.Write("Введите кол-во строк второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[n, m];
InputMatrix(matr);
Console.WriteLine("Произведение первой и второй матрицы: ");
ResultMatrix(matrix, matr);