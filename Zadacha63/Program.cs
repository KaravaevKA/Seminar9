//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Console.WriteLine("Введите число N");
int Num = Convert.ToInt32(Console.ReadLine());
int NumReturn(int N)
{
    if (N >= 1)
    {
        NumReturn(N-1);
        Console.WriteLine(N);
    }
    return N;
}
NumReturn(Num);