// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ReadInt(string message)
{
    System.Console.Write($"{message} >");       // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());     // Ввод числа
}

//  2   |    1
//-------------
//  3   |    4

int GetQuorter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }

    return 0;
}

bool ValidateXY(int x, int y)
{
    bool res = x == 0 || y == 0;
    if (res)
    {
        System.Console.WriteLine("Одна из координат находится на оси");
        return false;
    }

    return true;
}

int x = ReadInt("Введите X");
int y = ReadInt("Введите Y");
int numberQuorter = GetQuorter(x, y);
if (ValidateXY(x, y))
{
    System.Console.WriteLine($"Номер четверти для X, Y ({x}, {y}) равна {numberQuorter}");
}

