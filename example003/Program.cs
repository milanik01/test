// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
string Poliandrom(int num)
{

    int temp = num;
    int count = 0;
    int index = 0;
    double result1;
    double result2;
    

    while(temp>0)
    {
        temp = temp/10;
        count++;
    }  

    
    while(index<count/2)
    {
        
        result1 = Math.Round(num/Math.Pow(10,count-index-1),MidpointRounding.ToZero);
        result1=result1%10;

        result2 = num%Math.Pow(10,index+1)/Math.Pow(10,index);
        result2 = Math.Round(result2, MidpointRounding.ToZero);


        if(result1==result2)
        {
            index++;
        }
        else
        {
            return "no";
        }

        
    }
    return "Yes";
}


Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number+" -> "+Poliandrom(number));

*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Dist(double xx1, double yy1, double zz1, double xx2, double yy2, double zz2)
{
    double result;

    result = Math.Sqrt(Math.Pow((xx2-xx1),2)+Math.Pow((yy2-yy1),2)+Math.Pow((zz2-zz1),2));

    return result;
}


Console.WriteLine("Input x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Input x2 ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x3");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y1 ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y3 ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance is " + Math.Round(Dist(x1, y1, z1, y1, y2, z2)));
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void TabSqr(int num)
{
    int count = 1;
    while(count<=num)
    {
        Console.Write(Math.Pow(count,3)+" ");
        count++;
    }
}

Console.WriteLine("Input N ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(number+" -> ");
TabSqr(number);

*/