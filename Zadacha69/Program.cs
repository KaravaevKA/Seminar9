// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа");
// int B = Convert.ToInt32(Console.ReadLine());

// int DegreeNum(int NumFirst, int NumSecond)
// {
//     if (NumSecond>=1)
//     {
//         return (NumFirst * DegreeNum(NumFirst, NumSecond-1));
//     }
//     return NumFirst;
// }

// DegreeNum(A,B);
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(m,n)}");

int Pow(int number,int rank)
{
    if (rank == 0) return 1;
    else return (number * Pow(number,rank-1));
}