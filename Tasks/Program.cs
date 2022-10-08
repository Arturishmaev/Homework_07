//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] array = new double[3, 3];
Random rnd = new Random();


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10) + rnd.NextDouble();
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write($"{Math.Round (array[i, j], 2)}\t");
    }
    System.Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//            что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[3, 3];

FillArray(array);
PrintArray(array);
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rows = array.GetLength(0);
int columns = array.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (num == array[i, j])
        {
            System.Console.WriteLine("Ваше число есть в массиве"); 
        }
        else
        {
            System.Console.WriteLine("Ваше число не существует в массиве"); // С выводом проблемы , выводит строку на каждый элемент массива
        }                                                                   // как сделать без if-else я не знаю, вне цикла вывод не определяется
    }
}







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}



double[,] array = new double[3, 3];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int columns = array.GetLength(1);
int count = 0;
double sum = 0;
while (count < columns)
{
    sum = array[0, 0] + array[1, 0] + array[2, 0];
    count++;
}

double avg = sum / columns;
System.Console.WriteLine("Среднее арифметическое столбца [0]: " + (Math.Round(avg, 2)));



