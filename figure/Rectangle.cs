using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace FiguresLR1
{
    class Rectangle : Parallelogram
    {
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {

        }
         public override string PrintName() { return "прямоугольник"; }

        public override void PrintFigure()
        {
            Console.WriteLine( $"{PrintName()} со сторонами {x2 - x1},{y1 - y4} \n");
        }
    }
}

