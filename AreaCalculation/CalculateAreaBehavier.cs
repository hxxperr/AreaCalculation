namespace AreaCalculation
{
    public interface CalculateAreaBehavier
    {
        public double AreaCalc(params double[] parameterArray);
    }
    public class CircleAreaCalc : CalculateAreaBehavier
    {
        /// <summary>
        /// Площадь круга по радиусу
        /// </summary>
        /// <param name="parameterArray">Радиус</param>
        /// <returns></returns>
        public double AreaCalc(params double[] parameterArray)
        {
            if (parameterArray.Length > 1 && parameterArray.Length < 1)
            {
                throw new Exception("It's can be only one radius");
            }
            return Math.Round(Math.PI * parameterArray[0], 2);
        }
    }
    public class TriangleAreaCalc : CalculateAreaBehavier
    {
        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="parameterArray">Стороны треугольника</param>
        /// <returns></returns>
        public double AreaCalc(params double[] parameterArray)
        {
            if (parameterArray.Length > 3)
            {
                throw new Exception("It's can be only three sides");
            }
            double perimetr = 0;
            foreach (double num in parameterArray)
            {
                perimetr += num;
            }
            perimetr /= 2;

            double firstSide = parameterArray[0];
            double secondSide = parameterArray[1];
            double thirdSide = parameterArray[2];

            return Math.Round(AreaBy3SidesAndPerimetrFormula(perimetr, firstSide, secondSide, thirdSide), 2);
        }

        private double AreaBy3SidesAndPerimetrFormula(double perimetr, double firstSide, double secondSide, double thirdSide)
        {
            return Math.Sqrt(perimetr * (perimetr - firstSide) * (perimetr - secondSide) * (perimetr - thirdSide));
        }
    }
}
