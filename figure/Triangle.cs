using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Triangle : BaseFigure
    {
        private int A;
        private int B;
        private int C;

        public Triangle(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            
        }

        public override string PrintName() { return "трегуольник"; }
        public override void PrintFigure()
        {
            Console.WriteLine( $"{PrintName()} со сторонами {A},{B},{C} \n");
            
        }
    }
}

