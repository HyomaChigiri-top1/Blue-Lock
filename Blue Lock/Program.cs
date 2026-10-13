//практика 3

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Blue_Lock
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Добро\nпожаловать\nв\nC#!");
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Город\t\tНаселение");

//        string city1 = "Москва";
//        double population1 = 13.0;

//        string city2 = "Санкт-Петербург";
//        double population2 = 5.6;

//        string city3 = "Новосибирск";
//        double population3 = 1.6;

//        Console.WriteLine($"{city1}\t\t{population1} млн");
//        Console.WriteLine($"{city2}\t{population2} млн");
//        Console.WriteLine($"{city3}\t{population3} млн");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.BackgroundColor = ConsoleColor.DarkRed;
//        Console.ForegroundColor = ConsoleColor.White;

//        Console.WriteLine("Внимание: проверка системы!");

//        Console.ResetColor();
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {

//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("Статус: ОК");
//        Console.ResetColor();

//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine("Статус: Предупреждение");
//        Console.ResetColor();

//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Статус: Ошибка");
//        Console.ResetColor();
//    }
//}


//using System;
//using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Загрузка…");
//        Console.Beep(800, 300);
//        Thread.Sleep(1000);

//        Console.WriteLine("Обработка…");
//        Console.Beep(1200, 300);
//        Thread.Sleep(1000);

//        Console.WriteLine("Готово");
//        Console.Beep(1600, 500);
//    }
//}


//using System;
//using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        int progress = 10;
//        int step = 10;

//        while (progress <= 100)
//        {
//            string status = $"Загрузка: {progress}%";

//            Console.SetCursorPosition(0, Console.CursorTop);

//            Console.Write(status);

//            Thread.Sleep(500);

//            progress += step;
//        }

//        Console.WriteLine();
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите угол в градусах: ");
//        double aDeg = double.Parse(Console.ReadLine());
//        double aRad = aDeg * Math.PI / 180.0;
//        double cosA = Math.Cos(aRad);

//        if (Math.Abs(1 - cosA) < 1e-9 || Math.Abs(1 + cosA) < 1e-9)
//        {
//            Console.WriteLine("Ошибка: деление на ноль или неопределённость.");
//            return;
//        }

//        double term1 = Math.Sqrt((1 - cosA) / (1 + cosA));
//        double term2 = Math.Sqrt((1 + cosA) / (1 - cosA));
//        double result = term1 + term2;

//        Console.WriteLine($"Результат: {result}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите a: ");
//        double a = double.Parse(Console.ReadLine());
//        Console.Write("Введите b: ");
//        double b = double.Parse(Console.ReadLine());

//        if (b == 0 || a == 0 || a == b)
//        {
//            Console.WriteLine("Ошибка: деление на ноль или неопределённость.");
//            return;
//        }

//        double numerator = (a - b) * 8 * Math.Pow(b, 4);
//        double denominator = 4 * Math.Pow(b, 3) * (Math.Pow(a, 2) - a * b);
//        double result = numerator / denominator;

//        Console.WriteLine($"Результат: {result}");
//    }
//}


//практика 2

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите ФИО: ");
//        string fio = Console.ReadLine();

//        Console.WriteLine($"Практическая работу №1 выполнил: {fio}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите длину первой стороны прямоугольника: ");
//        double sideA = double.Parse(Console.ReadLine());

//        Console.Write("Введите длину второй стороны прямоугольника: ");
//        double sideB = double.Parse(Console.ReadLine());

//        double perimeter = 2 * (sideA + sideB);
//        double area = sideA * sideB;
//        double diagonal = Math.Sqrt(sideA * sideA + sideB * sideB);

//        Console.WriteLine($"Периметр прямоугольника: {perimeter}");
//        Console.WriteLine($"Площадь прямоугольника: {area}");
//        Console.WriteLine($"Длина диагонали: {diagonal}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первое число: ");
//        double num1 = double.Parse(Console.ReadLine());

//        Console.Write("Введите второе число: ");
//        double num2 = double.Parse(Console.ReadLine());

//        double square1 = num1 * num1;
//        double square2 = num2 * num2;

//        double averageOfSquares = (square1 + square2) / 2;

//        Console.WriteLine($"Среднее арифметическое квадратов: {averageOfSquares}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите длину ребра куба: ");
//        double edge = double.Parse(Console.ReadLine());

//        double faceArea = edge * edge;

//        double totalSurfaceArea = 6 * faceArea;

//        double volume = edge * edge * edge;

//        Console.WriteLine($"Площадь одной грани: {faceArea}");
//        Console.WriteLine($"Площадь полной поверхности: {totalSurfaceArea}");
//        Console.WriteLine($"Объём куба: {volume}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите радиус круга R: ");
//        double radius = double.Parse(Console.ReadLine());

//        double circumference = 2 * Math.PI * radius;

//        double area = Math.PI * radius * radius;

//        Console.WriteLine($"Длина окружности: {circumference}");
//        Console.WriteLine($"Площадь круга: {area}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите координаты первой вершины (x1 y1): ");
//        string[] coords1 = Console.ReadLine().Split();
//        double x1 = double.Parse(coords1[0]);
//        double y1 = double.Parse(coords1[1]);

//        Console.Write("Введите координаты второй вершины (x2 y2): ");
//        string[] coords2 = Console.ReadLine().Split();
//        double x2 = double.Parse(coords2[0]);
//        double y2 = double.Parse(coords2[1]);

//        Console.Write("Введите координаты третьей вершины (x3 y3): ");
//        string[] coords3 = Console.ReadLine().Split();
//        double x3 = double.Parse(coords3[0]);
//        double y3 = double.Parse(coords3[1]);

//        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
//        double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); 
//        double c = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); 

//        double perimeter = a + b + c;

//        double semiPerimeter = perimeter / 2;
//        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

//        Console.WriteLine($"Периметр треугольника: {perimeter}");
//        Console.WriteLine($"Площадь треугольника: {area}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите целое четырёхзначное число: ");
//        int number = int.Parse(Console.ReadLine());

//        number = Math.Abs(number);

//        int digit1 = number / 1000;          
//        int digit2 = (number / 100) % 10;   
//        int digit3 = (number / 10) % 10;    
//        int digit4 = number % 10;           

//        int sum = digit1 + digit2 + digit3 + digit4;

//        Console.WriteLine($"Сумма цифр числа: {sum}");
//    }
//}


//практика 4

// v0.1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int playerBall = 0, maxBalls = 5,
                posX = 2, posY = 0, opponentBall = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.ResetColor();
            // отрисовываем игрока
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("🏃");
            Console.ResetColor();
            Console.SetCursorPosition(0, 3);
            // строка состояния героя
            Console.WriteLine($"⚽ {playerBall}/{maxBalls}");
            // нахождение мяча
            Console.Write("Введите количество мячей: ");
            int.TryParse(Console.ReadLine(), out opponentBall);
            playerBall += opponentBall;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"⚽ {playerBall}/{maxBalls}");
            // перемещение игрока
            Console.Write("Введите направление движения: ");
            var key = Console.ReadKey();
            // перемещаем игрока направо
            if (key.Key == ConsoleKey.D)
            {
                Console.SetCursorPosition(posX, posY);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("*");
                posX += 1;
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("🏃");
                Console.ResetColor();
                Console.SetCursorPosition(0, 5);
            }
            // перемещаем игрока налево
            if (key.Key == ConsoleKey.A)
            {
                Console.SetCursorPosition(posX, posY);
                Console.BackgroundColor = ConsoleColor.Blue;
                posX -= 1;
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("🏃");
                Console.Write("*");
                Console.ResetColor();
                Console.SetCursorPosition(0, 5);
            }

        }
    }
}

