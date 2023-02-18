// Homework

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int Middle(int num)
{
    int result = num/10;
    result = result%10;
    return result;
}

int Input()
{
    while(true)
    {
        Console.WriteLine("Input three-digit number");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number>=100 && number<1000)
        {

            
            return number;
            //string snumber = Convert.ToString(number);
            //int len = snumber.Length;
        

            
        }

    }
}

int number = Input();
int finDigit = Middle(number);
Console.WriteLine("Base digit "+number+" Result middle digit "+ finDigit);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int TrityDigit(int num)
{
    while(num>999)
    {
        num=num/10;
    }
    return num%10;
}

Console.WriteLine("Input three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if(number<100)
{
    Console.WriteLine("No third number");
}
else 
{
    Console.WriteLine(TrityDigit(number));
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
string Sundaytest(int num)
{
    if(num>=6)
    {
        return "This day is sundey!";
    }
    else
    {
        return "This day is not sunday";
    }
}
int InputNumber()
{
    while(true)
    {
        Console.WriteLine("Input day of the week number");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number>0 && number<=7 )
        {
            return number;
        }

        else
        {
            Console.WriteLine("This is not day of week number");
        }
    }

}

int userNumber = InputNumber();
Console.WriteLine(Sundaytest(userNumber));
*/