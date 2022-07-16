// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 10000 || N > 99999)
{   
    Console.WriteLine("Число не является пятизначным");
    Console.WriteLine("Введите пятизначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}

if (Convert.ToString(N)[0] == Convert.ToString(N)[4] && Convert.ToString(N)[1] == Convert.ToString(N)[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
