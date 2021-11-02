using Lessons_2_Library;
using System;

namespace Lesson__1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Task№1

            Console.WriteLine($"Task№1{Environment.NewLine}Enters 2 numbers " +
                $"(A and B).{Environment.NewLine}Console solution (5*A+B^2)/(B-A)");

            Console.Write("Enter A=");
            double A1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter B=");
            double B1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Console solution{Environment.NewLine}" +
                $"(5 * {A1} + {B1}^2) / ({B1} - {A1}) = {LessonsHomeWork2.Task1(A1, B1)}");

            Console.ReadKey();
            Console.Clear();

            //Task№2

            Console.WriteLine($"Task№2{Environment.NewLine}(The user enters 2 string values (A and B)." +
    $"{Environment.NewLine}(Swap the contents of variables A and B.");

            Console.Write("Enter A=");
            string A2 = Console.ReadLine();
            Console.Write("Enter B=");
            string B2 = Console.ReadLine();

            LessonsHomeWork2.Task2(ref A2,ref B2);

            Console.WriteLine($"A={A2}{Environment.NewLine}" +
                $"B={B2}");

            Console.ReadKey();
            Console.Clear();

            //Task№3

            Console.WriteLine($"Task№3{Environment.NewLine}The user enters 2 numbers (A and B).{Environment.NewLine}" +
                $"Print to the console the result of dividing A by B and the remainder of the division.");

            Console.Write("Enter A=");
            double A3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B=");
            double B3 = Convert.ToDouble(Console.ReadLine());

            (double division, double remainder) = LessonsHomeWork2.Task3 (A3,B3);

            Console.WriteLine($"{A3} / {B3} = {division}{Environment.NewLine}" +
                $"%={remainder}");

            Console.ReadKey();
            Console.Clear();

            //Task№4

            Console.WriteLine($"Task№4{Environment.NewLine}The user enters 3 non-equal 0 numbers " +
                $"(A, B and C).{Environment.NewLine}Output to the console the solution (X value) of the " +
                $"standard linear equation, where A * X + B = C.");

            Console.Write("Enter A=");
            double A4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B=");
            double B4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter C=");
            double C4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{A4} * X + {B4} = {C4}{Environment.NewLine}" +
                $"x = ({C4} - {B4}) / {A4}{Environment.NewLine}" +
                $"x={LessonsHomeWork2.Task4(A4, B4, C4)}");

            Console.ReadKey();
            Console.Clear();

            //Task№5

            Console.WriteLine($"Task№5{Environment.NewLine}The user enters 4 numbers(X1, Y1, X2, Y2) " +
                $"describing the coordinates of 2 points on the coordinate plane.{Environment.NewLine}" +
                $"Output the equation of a straight line in the format Y = AX + B passing through these points.");

            Console.Write("Enter X1=");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1=");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X2=");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2=");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            (double A, double B) = LessonsHomeWork2.Task5(X1, Y1, X2, Y2);

            Console.WriteLine($"Y={A}X+{B}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tasks solving is over");
        }
    }
}