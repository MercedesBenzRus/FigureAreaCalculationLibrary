namespace FigureAreaCalculationLibrary.ModelsLib
{
    public class Triangle : IFigure
    {
        private readonly double _p;
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        private bool isRightTriangle;
        public double CalculateArea()
        {
            return Math.Sqrt ( _p * (_p - _a) * (_p - _b) * (_p - _c) );
        }
        public Triangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0) 
            { _a = 0; _b = 0; _c = 0; _p = 0; }

            else
            {
                _a = a;
                _b = b;
                _c = c;
                _p = (a + b + c) / 2;

                RightTriangleOrNot();
            }
        }
        private void RightTriangleOrNot()
        {
            double a2 = _a * _a;
            double b2 = _b * _b;
            double c2 = _c * _c;
            if ((a2 > b2 && a2 > c2 && a2 == b2 + c2) || 
                (b2 > a2 && b2 > c2 && b2 == a2 + c2) ||
                (c2 > a2 && c2 > b2 && c2 == a2 + b2) ) 
            {
                isRightTriangle = true;
            }
            else
                isRightTriangle = false;
            
        }
        public bool GetRightTriangleOrNot()
        {
            return isRightTriangle;
        }

    }
}
