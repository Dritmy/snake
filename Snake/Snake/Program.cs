using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            //Отрисовка рамки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightline = new VerticalLine(78, 0, 24, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            //Отрисовка точек
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            

            Console.ReadLine();

        }

    }
}
