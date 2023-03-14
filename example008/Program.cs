// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortArray(int [,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        int sort = 0;
        while(sort<array.GetLength(1))
        {
            int temp = 0;
            for(int j = 0; j<array.GetLength(1)-1; j++)
            {

                if(array[i,j]<array[i,j+1]) 
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
            sort++;
        }
        
    }

}

Console.WriteLine("Input rows ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] nArray = CreateArray(n, m);
ShowArray(nArray);
SortArray(nArray);
Console.WriteLine();
ShowArray(nArray);

*/



// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой 
//элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка
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

int [] SummRows(int [,]array)
{
    
    int [] summArray = new int[array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            summArray[i]=summArray[i]+array[i,j];
        }
    }
    return summArray;
}
int MinSumm(int []sArray)
{
    int min=0;
    for(int i = 1; i < sArray.GetLength(0); i++ )
    {
        if(sArray[i]<sArray[min])min=i;
    }
    return min+1;
}

Console.WriteLine("Input rows ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] nArray = CreateArray(n, m);
ShowArray(nArray);

Console.WriteLine();
Console.WriteLine("Minimal summ row number is "+MinSumm(SummRows(nArray)));
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultiMat(int [,] fArray, int [,] sArray)
{
    int [,] tArray = new int[fArray.GetLength(0), sArray.GetLength(1)];

    for(int z=0; z < tArray.GetLength(1); z++)
    {
       
            for(int i = 0; i<tArray.GetLength(0); i++)
            {
                for(int j = 0; j<sArray.GetLength(0); j++)
                {
                    tArray[i,z] = tArray[i,z]+ (fArray[i,j]*sArray[j,z]);
                }
                
            }
            
        
            Console.WriteLine();
    }

  return tArray;
}

bool exit = true;
while(exit)
{
    Console.WriteLine("Input parameters for first");
    Console.WriteLine("Input rows ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input columns ");
    int m = Convert.ToInt32(Console.ReadLine());
    int [,] firstArray = CreateArray(n,m);

    Console.WriteLine("Input parameters for second");
    Console.WriteLine("Input rows ");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input columns ");
    int p = Convert.ToInt32(Console.ReadLine());
    int [,] secondArray = CreateArray(l,p);
    ShowArray(firstArray);
    Console.WriteLine();
    ShowArray(secondArray);

    if(m==l) 
    {
       
        ShowArray(MultiMat(firstArray, secondArray));
        exit = false;
    }
    else Console.WriteLine("Input new digits ");

}

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
void CreateArray()
{
    int [,,] newArray = new int[2,2,2];
    for(int z=0; z<2; z++)
    {
        for(int i=0; i<2; i++)
        {
            for(int j=0; j<2; j++)
            {
                bool tst = true;
                while(tst)
                {
                    int temp = new Random().Next(10,100);
                    tst = Test(newArray, temp);
                    if(!Test(newArray, temp))newArray[i,j,z]=temp;
                    //Console.Write(newArray[i,j,z]+"["+i+","+j+","+z+"] ");
                    
                                    
                 }
                Console.Write(newArray[i,j,z]+"["+i+","+j+","+z+"] ");
                
            }
            Console.WriteLine();
        }
    }
    
}

bool Test(int[,,] array, int tempTest)
{
    for(int x=0; x<2; x++)
    {
        for(int y=0; y<2; y++)
        {
            for(int w = 0; w<2; w++)
            {
                if(array[x,y,w]==tempTest) return true;
                
                
            }
        }
    }
    return false;
}
CreateArray();
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
void CreateArray(int rows, int columns)
{
    int [,] newArray = new int[rows, columns];
    int exit = 0;
    int direct=0;
    int i = 0;
    int j = 0;
    int right = columns-1;
    int down = rows-1;
    int left = 0;
    int up = 0;

    while(exit < (rows * columns))
    {
        newArray[i,j] = exit;
        exit++;
        Console.Write(newArray[i,j]+"["+i+","+j+"]");
       //Console.WriteLine("direct = "+direct);
        if(direct==0) 
        {
            
            
            if(j==right)
            {
                up++;
                direct++;

            }
            else j++;
           // Console.WriteLine("j = "+j);
        }
        if(direct==1)
        {
            
            if(i==down) 
            {
                right--;
                direct++;
            }
            else i++;
        }
        Console.WriteLine();
        if(direct==2)
        {
            
            if(j==left)
            {
                down--;
                direct++;

            }
            else
            {
                //Console.WriteLine("j = "+j);
                j--;
            } 
            
        }
        if(direct==3)
        {
            //Console.WriteLine("up = "+ up);
            if(i==up)
            {
                left++;
                j++;
                direct = 0;
                
            }
            else i--;
            //Console.WriteLine("j = "+j);

        }
    }
      
}



Console.WriteLine("Input rows ");
int m = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input columns ");
int n = Convert.ToInt32(Console.ReadLine());
CreateArray(m,n);
*/