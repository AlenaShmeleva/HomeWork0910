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
Console.WriteLine("Первая матрица:");
int[,] matrix = new int[2, 2]; // Так как в условии не сказано, что матрица произвольно вводится пользователем.
InputMatrix(matrix);
Console.WriteLine("Вторая матрица:");
int[,] matr = new int[2, 2];
InputMatrix(matr);
Console.WriteLine("Произведение первой и второй матрицы: ");
ResultMatrix(matrix, matr);