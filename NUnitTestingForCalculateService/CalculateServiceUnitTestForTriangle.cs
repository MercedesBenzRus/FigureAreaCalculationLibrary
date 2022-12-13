using FigureAreaCalculationLibrary.Factories;
using FigureAreaCalculationLibrary.ModelsLib;
using NUnit.Framework;


namespace NUnitTestingForCalculateService
{
    public class CalculateServiceUnitTestForTriangle
    {
        internal CalculateService calcService;
        internal IFigure incorrectTriangle;
        internal IFigure correctTriangle;

        internal IFigure rightTriangle;


        [SetUp]
        public void Setup()
        {
            calcService = new CalculateService();
            correctTriangle = new Triangle(2, 5, 4);
            incorrectTriangle = new Triangle(2, 0, 8);

            rightTriangle = new Triangle(3, 5, 4);

        }

        [Test]
        public void TestMethodForCorrectTriangle()
        {
            double checkValueRadiusForCorrectTriangle = 3.7997;
            var result = calcService.CalculateServiceMethod(correctTriangle);

            Assert.That(checkValueRadiusForCorrectTriangle, Is.EqualTo(Math.Round(result, 4)));//Округление до 4 цифр после запятой
        }
        [Test]
        public void TestMethodForIncorrectTriangle()
        {
            double checkValueRadiusForIncorrectTriangle = 0.0;
            var result = calcService.CalculateServiceMethod(incorrectTriangle);

            Assert.That(checkValueRadiusForIncorrectTriangle, Is.EqualTo(result));
        }
        [Test]
        public void TestMethodForNotRightTriangle()
        {
            bool checkRightOrNotTriangle = false;
            var result = ((Triangle)correctTriangle).GetRightTriangleOrNot();

            Assert.That(checkRightOrNotTriangle, Is.EqualTo(result));
        }
        [Test]
        public void TestMethodForRightTriangle()
        {
            bool checkRightOrNotTriangle = true;
            var result = ((Triangle)rightTriangle).GetRightTriangleOrNot();

            Assert.That(checkRightOrNotTriangle, Is.EqualTo(result));
        }
    }
}