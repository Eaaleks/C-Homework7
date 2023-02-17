/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/




int[,] InitMatrix() //создаём массив
{
    int[,] matrix = new int[10,10];
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

Console.WriteLine("введите номер строки");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

 void FindNumber (int[,] matrix) //находим элемент массива
 {

              if (line > matrix.GetLength(0) || column > matrix.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
                else
                {
                    Console.WriteLine($"значение элемента {line} строки и {column} столбца равно {matrix[line-1,column-1]}");
                }
            }
     


int[,] matrix = InitMatrix();
FindNumber(matrix);
PrintMatrix(matrix);





