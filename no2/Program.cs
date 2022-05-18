// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
string GetRangeX(int quater)
{
    if (quater == 1 &&  quater == 4)
    {
        return ("X > 0");
    }
    else{
        return ("X < 0");
    }
}

string GetRangeY(int quater)
{
    if (quater == 1 && quater == 2)
        return ("Y > 0");
    else
        return ("Y < 0");
}


//функция, которая получает число, введенное с клавиатуры
// + проверка на то, что ввели именно число
// + проверка, что число != 0
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number != 0)
                return number;
            else
            {
                Console.WriteLine("Число должно отличаться от 0. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

string messageI = "Введите номер четверти I:";

int quater = GetNumber(messageI);


string x = GetRangeX(quater);
string y = GetRangeY(quater);

Console.WriteLine($"Диапазон лежит в {x} и {y}");