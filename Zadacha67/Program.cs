// Console.WriteLine("Введите число");
// int num =Convert.ToInt32(Console.ReadLine());
// void IndexSum(int A)
// {
//     int sum = 0;
//     if (A > 0)
//     {
//         IndexSum(A % 10);
        
//     }
// //     int sum = 0;
// //     int i = 1;
// //     while(A != 0)
// //     {
// //         while(i<A)
// //         {
// //             int b = A / i % 10;
// //             sum = sum + b;
// //             i = i*10;
// //         }
// //         Console.WriteLine(sum);
// //         break;
// //     }
// }
// IndexSum(num);
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр числа:"+Sum(num));
int Sum(int inputNum)
{
    if (inputNum < 10) return inputNum;
    else return inputNum % 10 + Sum(inputNum / 10);
}