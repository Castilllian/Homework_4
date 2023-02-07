// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int Method2(int a)
{
    if(a<0)
    {
        a *= -1;
    }
    int summ =0;
    for(;a>0;a/=10)
    {
        summ += a%10;
    }
    return summ;
}
Console.WriteLine($"Сумма чисел введенного числа = {Method2(num)}");

