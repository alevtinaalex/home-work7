//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 4;
int n = 4;
int[,] array = new int[m, n];
FillAndPrintArray(array);
System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
SrArifm(array);


void FillAndPrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SrArifm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double srar = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            srar = srar + array[j, i];
        }
        System.Console.Write(srar / array.GetLength(0) + "   ");
    }
}
