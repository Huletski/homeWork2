// task1 Дано число обозначающее день недели. Выяснить является номер дня недели выходным

/*
Console.WriteLine("Please enter day number for checking:");
var numberOfDay = int.Parse(Console.ReadLine());
switch (numberOfDay)
{
    case 1:
    Console.WriteLine("I'ts not weekend (:  ");
    break;
    case 2:
    Console.WriteLine("I'ts not weekend (:  ");
    break;
    case 3:
    Console.WriteLine("I'ts not weekend (:  ");
    break;
    case 4:
    Console.WriteLine("I'ts not weekend (:  ");
    break;
    case 5:
    Console.WriteLine("I'ts not weekend (:  ");
    break;
    case 6:
    Console.WriteLine("Hooray!!!!!!  WeekenD!!!!!!!!!!!");
    break;
    case 7:
    Console.WriteLine("Hooray!!!!!!  WeekenD!!!!!!!!!!!");
    break;
    default:
    Console.WriteLine("Mistake!!! Enter number from 1 to 7");
    break;
}

*/
// Task2 По двум заданным числам проверять является ли одно квадратом другого

/*
Console.WriteLine("Plese Enter first number:");
var firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Plese Enter second number:");
var secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Bingo!!!  It's True!");
}
else
{
Console.WriteLine("It's False!");
}

*/




// Task3
/*

Console.WriteLine("Введите номер четверти: ");
string enteredNumber = Console.ReadLine();

switch(enteredNumber)
{
    case "1":
    Console.WriteLine("Возможные диапазоны координат: x>0, y>0");
    break;

    case "2":
    Console.WriteLine("Возможные диапазоны координат: x<0, y>0");
    break;

    case "3":
    Console.WriteLine("Возможные диапазоны координат: x<0, y<0");
    break;

    case "4":
    Console.WriteLine("Возможные диапазоны координат: x>0, y<0");
    break;

    default:
    Console.WriteLine("Ошибка! Перезапустите программу и введите от 1 до 4");
    break;
}

*/

//task4 Найти расстояние между точками в пространстве 2D/3D

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}