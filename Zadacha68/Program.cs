int Akkermana (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkermana(n - 1, 1);
    else
      return Akkermana (n - 1, Akkermana (n, m - 1));
}

Console.WriteLine ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());


int a = Akkermana(n , m);
Console.WriteLine (a);