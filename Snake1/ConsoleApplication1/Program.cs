using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Point p1 = new Point(3, 3, '#');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move p1.x = " + p1.x + " "  + "Call Move p1.y = " + p1.y);

            Point p2 = new Point(5, 5, '@');
            p1 = p2;
            p2.x = 10;
            p2.y = 10;
            Console.WriteLine(p1.x + " " + p1.y + " " + p2.x + " " + p2.y + " ");

           /* p1 = new Point(1, 3, '#');
            Update(p1);
            Console.WriteLine(p1.x + " " + p1.y);
            /* Point p1 = new Point(3,3,'@');
             p1.Draw();

             Point p2 = new Point(4,5,'$');
             p2.Draw();


             /* Console.WriteLine("Hello!");*/
            Console.ReadLine();
        }
        public static void Func1(int value) { }
        public static void Func2(int value)
        {
            value = value + 5;
        }
        public static void Func3(int x)
        {
            x = x + 10;
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

       /* public static void Update(Point p)
        {
            p = new Point();
        }*/

    }
}
