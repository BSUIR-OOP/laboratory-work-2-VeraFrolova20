using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class section : BaseFigure
    {
        private int x1,y1;
        private int x2,y2;
        private int A,B;

        public section(int x1, int y1, int x2,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.A = x2 - x1;
            this.B = y2 - y1;

        }

         


        public override string PrintName() { return "отрезок"; }
        public override void PrintFigure()
        {
            Console.WriteLine($"{PrintName()} с кординатами A({x1},{y1}),B({x2},{y2}), длинной {Math.Sqrt(A*A+B*B)} \n");
        }

    }
}
