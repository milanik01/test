﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
void InputDigits(int n)
{
    int i = 0;
    int count = 0;
    while(i<n)
    {
        int digit = Convert.ToInt32(Console.ReadLine());
        if(digit>0) count++;
        i++;
    }
    Console.WriteLine(count+" positive digits");

}



int temp = 0;
int m = 0;
while(temp==0)
{
    Console.WriteLine("Input digit M > 0");
    m = Convert.ToInt32(Console.ReadLine());
    if(m>0) temp++;
    else Console.WriteLine(" Not correct ");
}

InputDigits(m);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void Lines(double k1, double b1, double k2, double b2)
{
    if(k1==k2&&b1==b2) Console.WriteLine("линии совпадают");
    else if (k1==k2) Console.WriteLine("линии паралельны");
    else
    {
        double x = (b2-b1)/(k1-k2);

        double y = k1*(b2-b1)/(k1-k2)+b1;

        Console.WriteLine("("+x+","+y+")");
    }

    
   
}

Console.WriteLine(" Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Lines(k1,b1,k2,b2);
*/