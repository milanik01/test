// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Roww(int aDigit, int bDigit)
{
    int result = 1;
    for(int i=0; i<bDigit; i++)
    {
        result = result * aDigit;
        //Console.WriteLine(result);
    }
    return result;
}

    Console.WriteLine("Input first digit");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input srecond digit");
    int b = Convert.ToInt32(Console.ReadLine());
    int res = Roww(a,b);
    Console.Write(a+", "+b+" -> "+res);
    */


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int Summ(int num)
{
    int result = 0;
    for(int i=0; i<=num; i++)
    {
        result = result + i;
    }

    return result;
}

Console.WriteLine("Input digit");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is "+ Summ(number));
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*

int[] Input(int num)
{
    
    int[] array = new int[num];
    for(int i=0; i<num; i++)
    {
        array[i] = new Random().Next(1,100);
        //Console.Write(" "+array[i]);
    }
    return array;
}
void Print(int[] array1)
{
    for(int i=0; i<array1.Length; i++)
    {
        Console.Write(" "+array1[i]);
    }
}


Console.WriteLine("Input quantity ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

int [] array = Input(arrayNum);
Print (array);

*/


