using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeFirkanter
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var box1 = new Box(random, 40, 18 );
            var box2 = new Box(random, 40, 18 );
            var screen = new VirtualScreen(50, 20);
            screen.Add(box1);
            screen.Add(box2);
            screen.Show();

            //Console.WriteLine(box.X);
            //Console.WriteLine(box.Y);
            //Console.WriteLine(box.Width);
            //Console.WriteLine(box.Height);


            //var cell = new ScreenCell();
            //cell.AddLowerLeftCorner();
            //cell.AddVertical();
            //var row = new ScreenRow(20, 10);
            //row.AddBoxTopRow();
            //row.Show();
            //Console.WriteLine();
            //row = new ScreenRow(20, 10);
            //row.AddBoxMiddleRow();
            //row.Show();
            //Console.WriteLine();
            //row = new ScreenRow(20, 10);
            //row.AddBoxBottomRow();
            //row.Show();
            //Console.WriteLine();
        }
    }
}
