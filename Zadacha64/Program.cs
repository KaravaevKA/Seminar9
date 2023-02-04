


// void NumReturn(int N, int m)
// {
//     if (m <= N)
//     {
//         NumReturn(m+1, N);
//         Console.WriteLine($"{m}");
//     }
// }
// Console.WriteLine("Введите число N");
// int NumN = Convert.ToInt32(Console.ReadLine());
// int NumM = 1;
// NumReturn(NumM, NumN);

void OutputNumbers(int m, int n) 
    {
      if (m <= n) {
          OutputNumbers(m + 1, n);
          Console.Write($"{m} ");
      }
    }

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = 1;
    OutputNumbers(m, n);