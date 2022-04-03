using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Ellipse: BaseFigure
    {
        private double mainAxis, additionalAxis;
        private protected int x, y;

        public Ellipse(int x1,int y1, double axis1,double axis2)
        {
            mainAxis = axis1;
            additionalAxis = axis2;
            x = x1;
            y = y1;
        }

        public override string PrintName() { return "эллипс"; }
        public override void PrintFigure() {
            Console.WriteLine($"{PrintName()} с центром в точке ({x},{y}) и полуосями ({mainAxis},{additionalAxis}) \n"); 
        }
    }
}
