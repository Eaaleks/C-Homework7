/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] InitMatrix() //создаём массив
{
    int[,] matrix = new int[3,3];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix) //выводим массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


double FindAverage (int[,]matrix)
{
   double average = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    average = result / matrix.GetLength(0);
    Console.WriteLine(average); 
}
    return average;
}



int[,] matrix = InitMatrix();
PrintMatrix(matrix);
FindAverage(matrix);
