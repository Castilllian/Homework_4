// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] Massive()
{
    Console.Write("Введите кол-во знаков массива: ");
    int N = int.Parse(Console.ReadLine());
    if(N==0)
    {
        Console.WriteLine("Неверное значение задано");
    }
    else if(N<0)
    {
        N*=-1;
    }
    int[] mass = new int[N];
    for(int i=0 ;i<N; i++)
    {
        mass[i]= new Random().Next(1,10);
    }
    return mass;
}
int[] vivod = Massive();
Console.WriteLine($"{String.Join(", ", vivod)}");