// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void Output(int num)
{
    if(num>0)
    {
        Console.Write(num+" ");
        Output(num-1);
    }
}

Console.WriteLine("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = " +n+ "->");
Output(n);

*/

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int Summ(int fnum, int snum, int sum)
{  
    if(fnum<snum) sum=fnum+Summ(fnum+1, snum, sum);
    if(fnum>snum) sum=snum+Summ(fnum, snum+1, sum);
    if(fnum==snum) sum=fnum;
    return sum;
}


Console.WriteLine("Input number first");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number second");
int m = Convert.ToInt32(Console.ReadLine());
int sum= 0;
Console.WriteLine($"N = {n} M = {m} -> {Summ(n,m ,sum)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0)){
        return Ack(m - 1, 1);
    }
    else if((m > 0) && (n > 0)){
        return Ack(m - 1, Ack(m, n - 1));
    }
    else return 0; 
}
 
int count = 0;

while(count == 0)
{
    Console.WriteLine("Input number first");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input number first");
    int n = Convert.ToInt32(Console.ReadLine());
    count = Ack(m,n);
    
    if(count>0) Console.WriteLine("-> "+count);

    else Console.WriteLine("Input again");
}
*/