using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1.1 Creating points and specifying their coordinates.");
            Console.ResetColor();

            Point point11 = new Point();
            point11.X = rnd.Next(-100, 101);
            point11.Y = rnd.Next(-100, 101);


            Point point12 = new Point();
            point12.X = rnd.Next(-100, 101);
            point12.Y = rnd.Next(-100, 101);


            Point point13 = new Point();
            point13.X = rnd.Next(-100, 101);
            point13.Y = rnd.Next(-100, 101);

            Console.WriteLine("Point 1 coordinates: " + point11.ToString());
            Console.WriteLine("Point 2 coordinates: " + point12.ToString());
            Console.WriteLine("Point 3 coordinates: " + point13.ToString());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("2.1 Create lines and specify their start and end points.");
            Console.ResetColor();

            Line line11 = new Line();
            line11.StartPoint = new Point(23, 8);
            line11.EndPoint = new Point(23, 8);

            Line line12 = new Line();
            line12.StartPoint = new Point(5, 10);
            line12.EndPoint = new Point(25, 10);

            Line line13 = new Line();
            line13.StartPoint = line11.StartPoint;
            line13.EndPoint = line12.EndPoint;

            Console.WriteLine(line11.ToString());
            Console.WriteLine(line12.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//Line 3, which always starts where line 1 starts and always ends where line 2 ends.");
            Console.ResetColor();
            Console.WriteLine(line13.ToString());

            
            line11.StartPoint.X = rnd.Next(-100, 101);
            line11.StartPoint.Y = rnd.Next(-100, 101);
            line11.EndPoint.X = rnd.Next(-100, 101);
            line11.EndPoint.Y = rnd.Next(-100, 101);

            line12.StartPoint.X = rnd.Next(-100, 101);
            line12.StartPoint.Y = rnd.Next(-100, 101);
            line12.EndPoint.X = rnd.Next(-100, 101);
            line12.EndPoint.Y = rnd.Next(-100, 101);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The coordinates of the first and second lines have been changed.");
            Console.ResetColor();
            Console.WriteLine(line11.ToString());
            Console.WriteLine(line12.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//Line 3, which always starts where line 1 starts and always ends where line 2 ends.");
            Console.ResetColor();
            Console.WriteLine(line13.ToString());

            
            line11.EndPoint.Y = rnd.Next(-100, 101);
            line11.EndPoint.Y = rnd.Next(-100, 101);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The coordinates of the first lines have been changed.");
            Console.ResetColor();   
            Console.WriteLine(line11.ToString());
            Console.WriteLine(line12.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//But the third line has not changed!");
            Console.ResetColor();
            Console.WriteLine(line13.ToString());


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("3.1 Create students with names and an array of grades.");
            Console.ResetColor();

            Student vasya = new Student("Vasya", new[] { 2, 3, 5 });
            Student petya = new Student("Petya");
            petya.Grades = vasya.Grades;

            Console.WriteLine(vasya.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Petya copies Vasya's grades.");
            Console.ResetColor();
            Console.WriteLine(petya.ToString());

            petya.Grades[0] = 5;

            Console.WriteLine();
            Console.WriteLine(vasya.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Petya's grades have been changed. The first grade is 5");
            Console.ResetColor();
            Console.WriteLine(petya.ToString());

            Student andrew = new Student("Andrew", vasya);

            Console.WriteLine();
            Console.WriteLine(vasya.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Andrew copies Vasya's grades.");
            Console.ResetColor();
            Console.WriteLine(andrew.ToString());

            andrew.Grades[0] = 4;

            Console.WriteLine();
            Console.WriteLine(vasya.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Andrew's grades have been changed. The first grade is 4");
            Console.ResetColor();
            Console.WriteLine(andrew.ToString());


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("4.1 Changed the Point constructor.");
            Console.ResetColor();

            Point point41 = new Point(3, 5);
            Console.WriteLine("Point 1 coordinates: " + point41.ToString());
            Point point42 = new Point(25, 6);
            Console.WriteLine("Point 1 coordinates: " + point42.ToString());
            Point point43 = new Point(7, 8);
            Console.WriteLine("Point 1 coordinates: " + point43.ToString());


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("4.1 Changed the Line constructor.");
            Console.ResetColor();

            Line line41 = new Line(1, 3, 23, 8);
            Console.WriteLine(line41.ToString());

            Line line42 = new Line (new Point(5, 10), new Point(25, 10));
            Console.WriteLine(line42.ToString());

            Line line43 = new Line(line41.StartPoint, line42.EndPoint);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//Line 3, which always starts where line 1 starts and always ends where line 2 ends.");
            Console.ResetColor();
            Console.WriteLine(line43.ToString());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("5.3 Line length function.");
            Console.ResetColor();

            Line line51 = new Line(1, 1, 10, 15);
            Console.WriteLine(line51.ToString());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//Line length.");
            Console.ResetColor();
            Console.WriteLine(line51.Length());

        }
    }
}
