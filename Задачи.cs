/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*
double[,] Create2DRandomArray (int minValue, int maxValue) 
{                                                                                
    int m = 3;
    int n = 4;
    double[,] newArray = new double[m,n];                                     
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newArray[i,j] = Math.Round(new Random().Next (minValue, maxValue) + new Random().NextDouble(),2);
            //newArray[i,j] = new Random().NextDouble()*(maxValue - minValue);
        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray(min,max);
Show2DArray(myArray);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
/*
int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
{                                                                                
    int[,] newArray = new int[rows,columns];                                     
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int FindElement (int[,] array, int x, int y)
{
    int result = -1;
    for(int i = 0; i < array.Length; i++)
    {
        if (x == i)
        for(int j = 0; j < array.Length; j++)
        {
            if (y == j)
            result = array [i,j];
        }
    }
    return result;
}
    


Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);

Console.Write("Введите номер строки ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца ");
int y = Convert.ToInt32(Console.ReadLine());
if(x>m || y>n )
{
Console.WriteLine($"Такого элемента в указанном массиве нет");
}
else
{
int total = FindElement (myArray, x, y);
Console.WriteLine($"Значение указанного элемента = {total}");
}
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] array = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};

for (int i = 0; i < 4; i++) 
    {
        double AverageCol = 0;
        for (int j = 0; j < 3; j++)
        {
            AverageCol += array[j, i];
            
        }
            Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {Math.Round(AverageCol/3,1)}");
    }
*/
        
int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
{                                                                                
    int[,] newArray = new int[rows,columns];                                     
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void ShowAverageColuumns (int[,] array, int m)
{

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    double result = avarage / m;
    Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {Math.Round(result,1)}");
}

Console.WriteLine();
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);

ShowAverageColuumns(myArray,m);

