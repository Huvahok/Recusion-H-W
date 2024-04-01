// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void Main()
{
    int M = ReadInt("Введите число 1: ");
    int N = ReadInt("Введите число 2: ");
    PrintInterval(M, N);
}


void PrintInterval(int M, int N)
{
    if (M < N + 1)
   
    {
        System.Console.Write(M +" ");
        PrintInterval(M + 1, N);
    }
}





int ReadInt(String msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();