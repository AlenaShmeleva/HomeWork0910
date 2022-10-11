// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
        
int [] FindSummaRowElement(int[,] matrix)
{
    int [] result = new int [matrix.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            summa += matrix[i, j];
        }
        result[index] = summa;
        index++; 
    }
    return result;
}
void FindMinRow(int[] array)
{
    int minRow = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (minRow > array[j])
            {
                minRow = array[j];
                row = j+1;
            }
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов - " + row);  
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов в строках по порядку: {String.Join(" ",FindSummaRowElement(matrix))}" );
FindMinRow(FindSummaRowElement(matrix));
