// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

//  2   |    1
//-------------
//  3   |    4

string GetRange(int Quorter) // возвращаемое значение функции(строки string) 
                             //getrange имя функции // (int Quorter  параметр функции)
{
    if (Quorter == 1)
        return ("X > 0 Y > 0");

    if (Quorter == 2)
        return ("X < 0 Y > 0");

    if (Quorter == 3)
        return ("X < 0 Y < 0");

    return ("X > 0 Y < 0");
}

bool ValidateXY(int Quorter)
{
    bool res = Quorter < 1 || Quorter > 4;
    if (res)
    {
        System.Console.WriteLine("Такой четверти не существует");
        return false;
    }
    return true;
}

int numberA = ReadInt("Введите значение");
if (ValidateXY(numberA))
{
    string range = GetRange(numberA);
    System.Console.WriteLine(range);
}

