// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num1}^{num2} = {Metod1(a: num1, b: num2)}");
int Metod1(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a ;
    }
    return result;
}