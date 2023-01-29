// Console.WriteLine("Введите число M");
// int NumM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int Num = Convert.ToInt32(Console.ReadLine());
// int NumReturn(int N, int M)
// {
//     if (N >= M)
//     {
//         NumReturn(N-1,M);
//         Console.WriteLine(N);
//     }
//     return N;
// }
// NumReturn(Num, NumM);
void OutputNumbers(int n, int m) 
{

    if (n >= m) {
        OutputNumbers(n - 1,m);
        Console.WriteLine(n);
    }

}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m) 
{
    OutputNumbers(n, m);
}
if (m>n)
{
    OutputNumbers(m, n);
}
if (m==n)
{
    Console.Write("Числа равны ");
}