//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N ");
string str_N = Console.ReadLine();
int int_N = Convert.ToInt32(str_N);
for (int i=1; i <= int_N; i++)
{
    Console.Write($"{i*i*i} ");
}