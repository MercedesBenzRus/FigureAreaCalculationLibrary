namespace FigureAreaCalculationLibrary.ModelsLib
{
    public class Circle : IFigure
    {
        private readonly double _r;
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
        public Circle(double r) 
        {
            if (r <= 0)
                _r = 0.0;
            else
                _r = r;
            
        }
    }
}
