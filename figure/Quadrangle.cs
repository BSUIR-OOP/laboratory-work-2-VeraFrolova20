using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Quadrangle : BaseFigure
    {
        private protected int x1, y1; 
        private protected int x2, y2;
        private protected int x3, y3;
        private protected int x4, y4;

        public Quadrangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override string PrintName() { return "четырёхугольник"; }
        public override void PrintFigure()
        {
            Console.WriteLine($"{PrintName()} с координатами A({x1},{y1}),B({x2},{y2}),C({x3},{y3}),D({x4},{y4}) \n");
        }
    }
}

