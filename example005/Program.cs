// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int [] Randarray() //create new massive
{
    int size = 0;
    
    Console.WriteLine("Input size massive");
    size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];
    for(int i= 0; i < size; i++)
    {
        array [i] = new Random().Next(100,999); 
    }
    return array;
}

void Printarray(int [] arr) //print massive
{
    for(int i = 0; i<arr.Length; i++ )
    {
        Console.Write(" "+arr[i]);
    }
}

int PositiveElements(int [] arr) //seach positive elements 
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++ )
    {
        if(arr[i]%2==0) count++;
    }
    return count;
}
int [] array2 = Randarray();
Printarray(array2);
Console.WriteLine();
Console.WriteLine("Positive elements "+PositiveElements(array2));

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int [] Randarray() //create new massive
{
    int size = 0;
    
    Console.WriteLine("Input size massive");
    size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];
    for(int i= 0; i < size; i++)
    {
        array [i] = new Random().Next(0,10); 
    }
    return array;
}

void Printarray(int [] arr) //print massive
{
    for(int i = 0; i<arr.Length; i++ )
    {
        Console.Write(" "+arr[i]);
    }
}

int Summ(int [] arr) //seach summ elements 
{
    int count = 0;
    for(int i = 0; i<arr.Length; i=i+2 )
    {
         count = count + arr[i];
    }
    return count;
}
int [] array2 = Randarray();
Printarray(array2);
Console.WriteLine();
Console.WriteLine("Summ elements "+ Summ(array2));
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
double [] Randarray() //create new massive
{
    int size = 0;
    
    Console.WriteLine("Input size massive");
    size = Convert.ToInt32(Console.ReadLine());
    double [] array = new double[size];
    for(int i= 0; i < size; i++)
    {
        array [i] = new Random().Next(0,100); 
    }
    return array;
}

double Max(double [] darray)
{
    double max = 0;
    for(int i = 0 ; i<darray.Length; i++ )
    {
        if(darray[i]>max) max = darray[i];
    }

    return max;
}

double Min(double [] darray)
{
    double min = darray[0];
    for(int i = 0 ; i<darray.Length; i++ )
    {
        if(darray[i]<min) min = darray[i];
    }

    return min;
}

void Printarray(double [] arr) //print massive
{
    for(int i = 0; i<arr.Length; i++ )
    {
        Console.Write(" "+arr[i]);
    }
}
double [] array2 = Randarray();
double result = Max(array2)-Min(array2);
Printarray(array2);
Console.WriteLine();
Console.WriteLine($" Result is {Max(array2)} - {Min(array2)} = {result}");
*/