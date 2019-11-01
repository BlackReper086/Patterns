using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{



    class Program
    {
        
        static void Main(string[] args)
        {
            List<Line> A = new List<Line>();
            Random rand = new Random();
            for (int i=0; i<20;i++)
            {
                LineEnd start, end;
                switch (rand.Next(0, 3))
                {
                    case 0: start = new JustLine();
                        break;
                    case 1: start = new LineArrow();
                        break;
                    case 2: start = new LineRomb();
                        break;
                    default: start = new JustLine();break;
                }
                switch (rand.Next(0, 3))
                {
                    case 0:
                        end = new JustLine();
                        break;
                    case 1:
                        end = new LineArrow();
                        break;
                    case 2:
                        end = new LineRomb();
                        break;
                    default: end = new JustLine(); break;
                }
                Line B = new Line(start,end);
                A.Add(B);
            }
            for(int i=0; i < A.Count; i++)
            {
                Console.Write("Линия №{0}\n",i+1);
                Console.Write (A[i].OutPutLine());
            }

            //List<int[]> points = new List<int[]>();
            //string[] xy = { "X1=", "\tY1=", "\tX2=", "\tY2=" };
            //Random rnd = new Random();
            //while (true)
            //{
            //    Console.WriteLine("1. add line (none, none)");
            //    Console.WriteLine("2. add line (strelka, strelka)");
            //    Console.WriteLine("3. add line (romb, romb)");
            //    Console.WriteLine("4. print lines");
            //    switch (Console.ReadLine())
            //    {
            //        case "1": points.Add(new int[]{
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        1,1}); break;
            //        case "2": points.Add(new int[]{
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        2,2}); break;
            //        case "3": points.Add(new int[]{
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        rnd.Next(-10, 11),rnd.Next(-10, 11),
            //        3,3}); break;
            //        case "4":
            //            foreach (int[] point in points)
            //            {
            //                for (int i = 0; i < 4; i++)
            //                    Console.Write(xy[i] + point[i]);
            //                switch (point[4])
            //                {
            //                    case 1: Console.Write("\t(none, "); break;
            //                    case 2: Console.Write("\t(strelka, "); break;
            //                    case 3: Console.Write("\t(romb, "); break;
            //                }
            //                switch (point[5])
            //                {
            //                    case 1: Console.Write("none)"); break;
            //                    case 2: Console.Write("strelka)"); break;
            //                    case 3: Console.Write("romb)"); break;
            //                }
            //                Console.WriteLine();
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Неизвестная команда");
            //            break;
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
