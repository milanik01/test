// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double [,] CreateArray(int rows, int columns)
{
    double [,] newArray = new double[rows, columns];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().NextDouble()*10;
        }
    }

    return newArray;

}

void ShowArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input rows ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input columns ");
int m = Convert.ToInt32(Console.ReadLine());

double [,] nArray = CreateArray(n, m);
ShowArray(nArray);*/

// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента
// нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> элемента с такими индексами в массиве нет

/*
int [,] CreateArray(int rows, int columns)
{
    int [,] newArray = new int[rows, columns];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(1,10);
        }
    }

    return newArray;

}

void ShowArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void getElement(int[,] array, int idI, int idJ)
{
    if(idI<=array.GetLength(0)&&idJ<=array.GetLength(1))
        Console.WriteLine("Element is " + array[idI, idJ]);
    else Console.WriteLine("Element is not available ");
}

Console.WriteLine("Input rows ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input columns ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] nArray = CreateArray(n, m);
ShowArray(nArray);

Console.WriteLine("Input index row ");
int indI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input index columns ");
int indJ = Convert.ToInt32(Console.ReadLine());

getElement(nArray, indI, indJ);
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int [,] CreateArray(int rows, int columns)
{
    int [,] newArray = new int[rows, columns];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(1,10);
        }
    }

    return newArray;

}

void ShowArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void Summ(int [,] array)
{
    int [] sum = new int [array.GetLength(1)];

    for(int i = 0; i<array.GetLength(1); i++)
    {
        for(int j=0; j<array.GetLength(0); j++)
        {
             sum[i] = sum[i]+array[j,i];
        }
        Console.WriteLine("Column "+i+" summ = "+ sum[i]);
    }

    
    
}
Console.WriteLine("Input rows ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input columns ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] nArray = CreateArray(n, m);
ShowArray(nArray);
Summ(nArray);
*/
