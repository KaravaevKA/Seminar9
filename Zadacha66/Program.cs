Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n)
    return n;
    return n + CountNaturalSum(m, n - 1);
}