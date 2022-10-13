// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

    void InputMatrix(int[,,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {  
                        matrix[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
}
void PrintMatrix(int[,,] matrix)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {    
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
                    Console.WriteLine();

                }
            }
            
        }
    }
Console.Write("Введите ширину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z];
InputMatrix(matrix);
PrintMatrix(matrix);