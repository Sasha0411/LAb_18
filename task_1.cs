using System;

namespace lab_18
{
    // Базовий клас Point
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() // Конструктор без параметрів
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y) // Конструктор з параметрами
        {
            X = x;
            Y = y;
        }

        public virtual void Display() // Метод для виведення інформації
        {
            Console.WriteLine($"Point: X = {X}, Y = {Y}");
        }
    }

    // Похідний клас Point3D
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D() : base() // Конструктор без параметрів
        {
            Z = 0;
        }

        public Point3D(int x, int y, int z) : base(x, y) // Конструктор з параметрами
        {
            Z = z;
        }

        public override void Display() // Перевизначення методу Display
        {
            Console.WriteLine($"Point3D: X = {X}, Y = {Y}, Z = {Z}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Створення одного об'єкта
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine("Один об'єкт:");
            point.Display();

            // 2. Створення масиву об'єктів
            Point3D[] points = new Point3D[3];
            points[0] = new Point3D(1, 2, 3);
            points[1] = new Point3D(4, 5, 6);
            points[2] = new Point3D(7, 8, 9);

            Console.WriteLine("\nМасив об'єктів:");
            foreach (var p in points)
            {
                p.Display();
            }

            // 3. Підрахунок суми координати X
            int sumX = 0, sumY = 0, sumZ = 0;
            foreach (var p in points)
            {
                sumX += p.X;
                sumY += p.Y;
                sumZ += p.Z;
            }

            Console.WriteLine($"\nСума координат X: {sumX}");

            // 4. Створення нового об'єкта із сумою координат
            Point3D sumPoint = new Point3D(sumX, sumY, sumZ);
            Console.WriteLine("\nНовий об'єкт із сумою координат:");
            sumPoint.Display();

            Console.ReadKey();
        }
    }
}
