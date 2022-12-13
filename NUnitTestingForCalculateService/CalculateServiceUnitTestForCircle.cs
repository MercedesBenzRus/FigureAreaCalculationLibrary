using FigureAreaCalculationLibrary.Factories;
using FigureAreaCalculationLibrary.ModelsLib;
using NUnit.Framework;


namespace NUnitTestingForCalculateService
{
    public class CalculateServiceUnitTestForCircle
    {
        internal CalculateService calcService;
        internal IFigure incorrectCircle;
        internal IFigure correctCircle;


        [SetUp]
        public void Setup()
        {
            calcService = new CalculateService();
            correctCircle = new Circle(2.0);
            incorrectCircle = new Circle(-3.0);
            
        }

        [Test]
        public void TestMethodForCorrectCircle()
        {
            double checkValueRadiusForCorrectCircle = 12.5664;
            var result = calcService.CalculateServiceMethod(correctCircle);

            Assert.That(checkValueRadiusForCorrectCircle, Is.EqualTo(Math.Round(result, 4))); //Округление до 4 цифр после запятой
        }
        [Test]
        public void TestMethodForIncorrectCircle()
        {
            double checkValueRadiusForIncorrectCircle = 0.0;
            var result = calcService.CalculateServiceMethod(incorrectCircle);
            
            Assert.That(checkValueRadiusForIncorrectCircle, Is.EqualTo(result));
        }
    }
}