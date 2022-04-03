using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Circle : Ellipse
    {
        private double radius;

        public Circle(int x1, int y1, double r):base(x1,y1,r,r)
        {
            radius = r;
            this.x = x1;
            this.y = y1;
        }

        public override string PrintName() { return "круг"; }
        public override void PrintFigure()
        {
            Console.WriteLine($"{PrintName()} с центром в точке ({x},{y}) и радиусом {radius} \n");
        }
    }
}
