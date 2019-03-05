using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math400Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 2.1 - 8b
            //double a = 4.4d, b = 4.5d, TOL = .00001f;
            //int maxIterations = 30;

            //int i = 0;
            //double p = 0;
            //double FP = 0, FA = Math.Tan(a) - a;
            //while (i < 17)
            //{
            //    p = a + (b - a) / 2f;
            //    FP = Math.Tan(p) - p;

            //    Console.Write($"Iteration: {++i}".PadRight(20));
            //    Console.Write($"| a: {a}".PadRight(20));
            //    Console.Write($"| b: {b}".PadRight(20));
            //    Console.Write($"| p: {p}".PadRight(20));
            //    Console.Write($"| f(p): {Math.Tan(p)}\n");

            //    //if (FP == 0 || (b-a)/2d < TOL)// || Math.Abs((b-a)/2f) < TOL) //THIS IS FOR ZEROES ONLY
            //    //{
            //    //    Console.WriteLine($"\nSuccess! First positive instance of a bisection at: {Math.Tan(p)}");
            //    //    Console.WriteLine($"It took {i} iterations to solve.\n");
            //    //    return;
            //    //}

            //    if (FA * FP > 0)
            //    {
            //        a = p;
            //        FA = FP;
            //    }
            //    else
            //    {
            //        b = p;
            //    }
            //}

            //Console.WriteLine("\nFailure to find a positive bisection.");
            #endregion

            #region Problem 2.2 - 2a
            //double result = 0;
            //for (int it = 0; it < 4; it++)
            //{
            //    if(it == 0)
            //    {
            //        result = g4x(1);
            //        Console.WriteLine($"({it + 1}): g(1): {result}");
            //    }
            //    else
            //    {
            //        Console.Write($"({it + 1}): g({result}): ");
            //        result = g4x(result);
            //        Console.WriteLine($"{result}");
            //    }

            //}
            #endregion

            #region Problem 2.2 - 6, 12d
            //int i = 0, maxIterations = 30;
            //double TOL = .00001d;
            //double currentP = 0, formerP = 0.5d;
            //while(i < maxIterations)
            //{
            //    //currentP = Math.Pow(formerP + 1, 1 / 3d);
            //    currentP = Math.Cos(formerP);
            //    //currentP = (2 - Math.Pow(Math.E, formerP) + Math.Pow(formerP, 2)) / 3d;

            //    Console.Write($"Iteration: {++i}".PadRight(25));
            //    Console.Write($"| p0: {formerP}".PadRight(25));
            //    Console.Write($"| p: {currentP}".PadRight(25));
            //    Console.WriteLine($"| |p - p0| : {Math.Abs(currentP - formerP)}".PadRight(25));

            //    if (Math.Abs(currentP - formerP) < TOL)
            //    {
            //        Console.WriteLine($"\nSuccess at p: {currentP}");
            //        return;
            //    }
            //    formerP = currentP;
            //}
            #endregion

            #region Newton's
            double formerP = 3.5f, currentP = 0, TOL = .00001d, maxIterations = 50;

            int i = 0;

            while (i < maxIterations)
            {
                currentP = formerP - (Math.Pow(formerP, 3) - 7 * Math.Pow(formerP, 2) + 14 * formerP - 6) / (3 * Math.Pow(formerP, 2) - 14 * Math.Pow(formerP, 1) + 14);

                Console.Write($"Iteration: {++i}".PadRight(25));
                Console.Write($"| p0: {formerP}".PadRight(25));
                Console.Write($"| p: {currentP}".PadRight(25));
                Console.WriteLine($"| |p - p0| : {Math.Abs(currentP - formerP)}".PadRight(25));

                if (Math.Abs(currentP - formerP) < TOL)
                {
                    Console.WriteLine($"\nSuccess at p: {currentP}");
                    return;
                }

                formerP = currentP;
            }

            //Console.WriteLine(Math.Pow(currentP, 4) - 4 * Math.Pow(currentP, 2) - 3 * currentP + 5);
            #endregion

            #region Secant
            //double p0 = -1, p1 = 0, TOL = .0001d, maxIterations = 4;


            //double q0 = -Math.Pow(p0, 3) - Math.Cos(p0);
            //double q1 = -Math.Pow(p1, 3) - Math.Cos(p1);

            //double p;

            //int i = 1;



            //while (i < maxIterations)
            //{
            //    p = p1 - (q1 * (p1 - p0)) / (q1 - q0);

            //    Console.Write($"Iteration: {i}".PadRight(25));
            //    Console.Write($"| p{i - 1}: {p0}".PadRight(25));
            //    Console.Write($"| p{i}: {p1}".PadRight(25));
            //    Console.Write($"| p: {p}".PadRight(25));
            //    Console.WriteLine($"| |p - p{i}| : {Math.Abs(p - p1)}".PadRight(25));

            //    if (Math.Abs(p - p1) < TOL)
            //    {
            //        Console.WriteLine($"Success at p: {p}");
            //    }

            //    i++;

            //    p0 = p1;
            //    q0 = q1;
            //    p1 = p;
            //    q1 = -Math.Pow(p, 3) - Math.Cos(p);
            //}
            #endregion

            #region False Position
            //double p0 = -1, p1 = 0, TOL = .0001d, maxIterations = 4;


            //double q0 = -Math.Pow(p0, 3) - Math.Cos(p0);
            //double q1 = -Math.Pow(p1, 3) - Math.Cos(p1);

            //double p, q;

            //int i = 1;



            //while (i < maxIterations)
            //{
            //    p = p1 - (q1 * (p1 - p0)) / (q1 - q0);

            //    Console.Write($"Iteration: {i}".PadRight(25));
            //    Console.Write($"| p{i - 1}: {p0}".PadRight(25));
            //    Console.Write($"| p{i}: {p1}".PadRight(25));
            //    Console.Write($"| p: {p}".PadRight(25));
            //    Console.WriteLine($"| |p - p{i}| : {Math.Abs(p - p1)}".PadRight(25));

            //    if (Math.Abs(p - p1) < TOL)
            //    {
            //        Console.WriteLine($"Success at p: {p}");
            //    }

            //    i++;

            //    q = -Math.Pow(p, 3) - Math.Cos(p);

            //    if(q * q1 < 0)
            //    {
            //        p0 = p1;
            //        q0 = q1;
            //    }

            //    p1 = p;
            //    q1 = q;
            //}
            #endregion
        }

        public static double g1x(double p)
        {
            return Math.Pow((3 + p - 2 * Math.Pow(p, 2)), .25f);
        }

        public static double g2x(double p)
        {
            return Math.Pow((p + 3 - Math.Pow(p, 4))/2f, .5f);
        }

        public static double g3x(double p)
        {
            return Math.Pow((p + 3)/(Math.Pow(p, 2) + 2), .5f);
        }

        public static double g4x(double p)
        {
            return (3 * Math.Pow(p, 4) + 2 * Math.Pow(p, 2) + 3) / (4 * Math.Pow(p, 3) + 4 * p - 1);
        }
    }
}
