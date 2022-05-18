/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

double X { get; }
double Y { get; }
double Z { get; }

double Point3D(double x, double y, double z){
X = x;
Y = y;
Z = z;
}

double Point3D(){
    Console.Write("Введите координаты x: ");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты y: ");
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты z: ");
        var z = Convert.ToDouble(Console.ReadLine());
        return new Point3D(x, y, z);
}

double Distance(Point3D p1, Point3D p2){
    return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }

void Read3DScenario()
    {
        _readerWriter.WriteLine("Введите первую точку:");
        var p1 = _readerWriter.Read3DPoint();
        _readerWriter.WriteLine("Введите вторую точку:");
        var p2 = _readerWriter.Read3DPoint();
        var distance = GeomertyMath.Distance(p1, p2);
        _readerWriter.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
    }

int GetNumber(string msg)
{
while(true)
{
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number != 0)  
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

string messageX = "Введите число х:";


int x = GetNumber(messageX);


int quater = GetQuarter(x);

