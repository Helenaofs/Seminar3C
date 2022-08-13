// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
void checkNum(string num)
{
    if (num.Length == 5)
    {
        if ((num[0] == num[4]) && (num[1] == num[3]))
        {
            Console.WriteLine("Число " + num + " - палиндром.");
        }
        else
        {
            Console.WriteLine("Число " + num + " - не палиндром.");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число!");
    }
}

checkNum(num);