using FigureAreaCalculationLibrary.ModelsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationLibrary.Factories
{
    public class CalculateService
    {
        public double CalculateServiceMethod(IFigure figure) 
        {
            if (figure != null)
            {
                return figure.CalculateArea();
            }
            return 0.0;
            
        }
    }
}
