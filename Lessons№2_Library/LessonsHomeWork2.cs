using System;

namespace Lessons_2_Library
{
    public class LessonsHomeWork2
    {
        public static double Task1(double A, double B)
        {
            return ((5 * A + B * B) / (B - A));
        }

        public static void Task2(ref string A, ref string B)
        {
            string temp = A;
            A = B;
            B = temp;

        }

        public static (double division, double remainder) Task3(double A, double B)
        {
            return (A / B, A % B);
        }

        public static double Task4(double A, double B, double C)
        {
            return (C - B) / A;

        }

        public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
        {
            double A = (Y2 - Y1) / (X1 - X2) / 2;
            double B = Y2 - A * X2;

            return ((Y2 - Y1) / (X1 - X2) / 2, Y2 - A * X2);

        }
    }
}
