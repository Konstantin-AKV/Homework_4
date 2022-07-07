// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

/* Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int B = int.Parse(Console.ReadLine());
int Pow(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i ++)
    {
        result = result * A;
    }
    return result;
}
int pow = Pow(A, B);
Console.WriteLine("A в степени B = " + pow);
 */

 
// Задача 27: Сумма всех чисел в указанной цифре

/* Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int SumNumb(int N)
{
    int sum = 0;
    int a = 0;
    for (; N > 0; N = N / 10)
    {
        a = N % 10;
        sum = sum + a;
    }
    return sum;
}
int sum_n = SumNumb(N);
Console.WriteLine("Сумма цифр числа = " + sum_n); */


// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 100);
}
Print(mass);