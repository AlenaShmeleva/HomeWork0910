// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
 Console.Clear();

    void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                    matrix[i, k] = new Random().Next(1, 11);
            }
        }
    }

void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
                Console.Write(matrix[i, k] + " \t");
                Console.WriteLine();
        }
    }
        
void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k+1])
                {
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, k+1];
                matrix[i, k+1] = temp;
                }
            }
        }   
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Ответ: ");
SortMatrix(matrix);
PrintMatrix(matrix);