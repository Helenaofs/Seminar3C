// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void TableCube(int[] num)
{
    int length = num.Length;
    int position = 0;

    while (position < length)
    {
        num[position] = Convert.ToInt32(Math.Pow(position, 3));
        position++;
    }
}

void PrintTableCube(int[] list)
{
    int length = list.Length;
    int index = 1;

    while (index < length)
    {
        Console.Write(list[index] + " ");
        index++;
    }
}

int[] array = new int[number+1];
TableCube(array);
PrintTableCube(array);
