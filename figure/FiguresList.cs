using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class FiguresList
    {
        private List<BaseFigure> figureItems;
        public BaseFigure this[int index]
        {
            get { return figureItems[index]; }
            set { figureItems.Add(value); }
        }
        public FiguresList()
        {
            figureItems = new List<BaseFigure>();
        }

    }
}
