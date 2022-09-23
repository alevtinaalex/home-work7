// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 4;
int n = 4;
int[,] array = new int[m, n];
FillAndPrintArray(array);
System.Console.WriteLine("Введите число");
int pos = Convert.ToInt32(Console.ReadLine());
if (FindNumbers(array, pos) == false)
{
    System.Console.WriteLine("нет этого числа");
}
else System.Console.WriteLine("Есть это число"); 


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

bool FindNumbers(int[,] array, int pos)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == pos)
                return true;
        }
    }
    return false;
}

