using System;

namespace lab_18
{
    // Базовий клас Person
    public class Person
    {
        public string LastName { get; set; }
        public int Height { get; set; } // у сантиметрах
        public int Weight { get; set; } // у кілограмах
        public int BirthYear { get; set; }

        public Person() // Конструктор без параметрів
        {
            LastName = "Unknown";
            Height = 0;
            Weight = 0;
            BirthYear = 0;
        }

        public Person(string lastName, int height, int weight, int birthYear) // Конструктор з параметрами
        {
            LastName = lastName;
            Height = height;
            Weight = weight;
            BirthYear = birthYear;
        }

        public virtual void Display() // Віртуальний метод для виведення інформації
        {
            Console.WriteLine($"Person: {LastName}, Height: {Height} cm, Weight: {Weight} kg, Year of Birth: {BirthYear}");
        }
    }

    // Похідний клас Player
    public class Player : Person
    {
        public int GamesPlayed { get; set; }
        public int GoalsScored { get; set; }

        public Player() : base() // Конструктор без параметрів
        {
            GamesPlayed = 0;
            GoalsScored = 0;
        }

        public Player(string lastName, int height, int weight, int birthYear, int gamesPlayed, int goalsScored)
            : base(lastName, height, weight, birthYear) // Виклик конструктора базового класу
        {
            GamesPlayed = gamesPlayed;
            GoalsScored = goalsScored;
        }

        public override void Display() // Перевизначений метод для виведення інформації
        {
            base.Display(); // Виклик методу базового класу
            Console.WriteLine($"Games Played: {GamesPlayed}, Goals Scored: {GoalsScored}");
        }

        public double AverageGoalsPerGame() // Метод для обчислення середнього забитих м’ячів
        {
            return GamesPlayed > 0 ? (double)GoalsScored / GamesPlayed : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

           // Створення 3 об'єктів
           Player player1 = new Player("Smith", 180, 75, 1990, 20, 10);
            Player player2 = new Player("Johnson", 185, 80, 1992, 15, 8);
            Player player3 = new Player("Williams", 175, 70, 1995, 30, 25);

            // Виведення інформації про кожний об'єкт
            Console.WriteLine("Player 1:");
            player1.Display();

            Console.WriteLine("\nPlayer 2:");
            player2.Display();

            Console.WriteLine("\nPlayer 3:");
            player3.Display();

            // Визначення середнього значення забитих м’ячів за гру для Player1
            double avgGoals1 = player1.AverageGoalsPerGame();
            Console.WriteLine($"\nPlayer 1 - Average Goals Per Game: {avgGoals1:F2}");

            Console.ReadKey();
        }
    }
}
